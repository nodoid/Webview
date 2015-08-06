using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace oqhra_android
{
    [Activity(Theme = "@android:style/Theme.NoTitleBar")]
    public class modal : Activity
    {
        private bool mChoice = false;
        private bool mQuitModal = false;

        private IntPtr mMsgQueueNextMethod;
        private IntPtr mMsgTargetField;

        public modal()
        { }

        public void showAlertDialog(Context context, string info)
        {
            if (!prepareModal())
                return;

            AlertDialog.Builder builder = new AlertDialog.Builder(context);
            builder.SetMessage(info);
            builder.SetCancelable(false);
            builder.SetPositiveButton("OK", (object o, Android.Content.DialogClickEventArgs e) =>
            {
                this.mQuitModal = true;
                builder.Dispose(); // was dialog.dismiss()
            });

            AlertDialog alert = builder.Create();
            alert.Show();

            doModal();
        }

        public bool showConfirmDialog(Context context, string info)
        {
            if (!prepareModal())
                return false;
            // reset choice
            mChoice = false;

            AlertDialog.Builder builder = new AlertDialog.Builder(context);
            builder.SetMessage(info);
            builder.SetCancelable(false);
            builder.SetPositiveButton("OK", (object o, Android.Content.DialogClickEventArgs e) =>
                {
                    this.mQuitModal = true;
                    this.mChoice = true;
                    builder.Dispose();
                });

            builder.SetNegativeButton("Cancel", (object o, Android.Content.DialogClickEventArgs e) =>
                {
                    mQuitModal = true;
                    mChoice = false;
                    builder.Dispose(); // probably wrong
                });

            AlertDialog alert = builder.Create();
            alert.Show();

            doModal();
            return mChoice;
        }

        private bool prepareModal()
        {
            using (var MessageQueue_Class = Java.Lang.Class.FromType(typeof(Android.OS.MessageQueue)))
            using (var Message_Class = Java.Lang.Class.FromType(typeof(Android.OS.Message)))
            {
                mMsgQueueNextMethod = JNIEnv.GetMethodID(MessageQueue_Class.Handle,
                        "next", "()Landroid/os/Message;");
                mMsgTargetField = JNIEnv.GetFieldID(Message_Class.Handle,
                        "target", "Landroid/os/Handler;");
                return true;
            }
        }

        private void doModal()
        {
            mQuitModal = false;

            // get message queue associated with main UI thread
            MessageQueue queue = Looper.MyQueue();
            while (!mQuitModal)
            {
                // call queue.next(), might block
                Message msg = null;
                try
                {
                    IntPtr _msg = JNIEnv.CallObjectMethod(queue.Handle, mMsgQueueNextMethod);
                    if (_msg == IntPtr.Zero)
                        return;

                    using (msg = Java.Lang.Object.GetObject<Android.OS.Message>(_msg, JniHandleOwnership.TransferLocalRef))
                    {
                        IntPtr _target = JNIEnv.GetObjectField(msg.Handle, mMsgTargetField);
                        if (_target == IntPtr.Zero)
                        {
                            mQuitModal = true;
                            return;
                        }
                        using (var target = Java.Lang.Object.GetObject<Android.OS.Handler>(_target, JniHandleOwnership.TransferLocalRef))
                        {
                            target.DispatchMessage(msg);
                            msg.Recycle();
                        }
                    }
                }
                catch (System.Exception e)
                { }
            }
        }
    }
}