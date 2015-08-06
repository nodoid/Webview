namespace POHWS
{
    public class webservice
    {
        /// <remarks/>
        [System.Web.Services.WebServiceBinding(Name = "Service1Soap", Namespace = "http://www.ret.bz/")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol
        {
            private System.Threading.SendOrPostCallback GetProfileOperationCompleted;
            private System.Threading.SendOrPostCallback GeneratePOHUnResOperationCompleted;
            private System.Threading.SendOrPostCallback UpdatePOHGPSOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHAdditionsOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHListingByIdOperationCompleted;
            private System.Threading.SendOrPostCallback GetImagesOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHListingById_POHIDOperationCompleted;
            private System.Threading.SendOrPostCallback GetBookmarksPOHOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHAllPreviewOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHAllPreviewREOperationCompleted;
            private System.Threading.SendOrPostCallback GetEStallionsOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHAllPreviewSearchOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHAllPreviewSearchREOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHAllPreviewSearchREWebOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHAllPreviewBetaOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHGeoOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHCitiesByAreaOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHCitiesOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHOpenDateOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHCompanyOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHBuildersOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHListingsOperationCompleted;
            private System.Threading.SendOrPostCallback GetTipSheetsOperationCompleted;
            private System.Threading.SendOrPostCallback GetOvernightsOperationCompleted;
            private System.Threading.SendOrPostCallback GetSpIDOperationCompleted;
            private System.Threading.SendOrPostCallback GetFeaturedOperationCompleted;
            private System.Threading.SendOrPostCallback GetFeaturedNewOperationCompleted;
            private System.Threading.SendOrPostCallback GetStoryOperationCompleted;
            private System.Threading.SendOrPostCallback GetCallByDateOperationCompleted;
            private System.Threading.SendOrPostCallback GetRaceDatesOperationCompleted;
            private System.Threading.SendOrPostCallback GetVidsByDateOperationCompleted;
            private System.Threading.SendOrPostCallback GetRaceEntriesFromEQOperationCompleted;
            private System.Threading.SendOrPostCallback GetUpcomingRacesListBUOperationCompleted;
            private System.Threading.SendOrPostCallback GetHRSponsorOperationCompleted;
            private System.Threading.SendOrPostCallback GetHRSponsorListOperationCompleted;
            private System.Threading.SendOrPostCallback GetUpcomingRacesListOperationCompleted;
            private System.Threading.SendOrPostCallback GetUpcomingRacesListDBOperationCompleted;
            private System.Threading.SendOrPostCallback GetResultsListOperationCompleted;
            private System.Threading.SendOrPostCallback GetResultsListV2OperationCompleted;
            private System.Threading.SendOrPostCallback GetResultsListNewOperationCompleted;
            private System.Threading.SendOrPostCallback AlexTestOperationCompleted;
            private System.Threading.SendOrPostCallback GetResultsListDBOperationCompleted;
            private System.Threading.SendOrPostCallback GetRacesFromEQOperationCompleted;
            private System.Threading.SendOrPostCallback GetRaceResultsEntriesFromEQOperationCompleted;
            private System.Threading.SendOrPostCallback GetRacesResultsFromEQOperationCompleted;
            private System.Threading.SendOrPostCallback GetStakeDatesOperationCompleted;
            private System.Threading.SendOrPostCallback GetTrackOperationCompleted;
            private System.Threading.SendOrPostCallback GetStakesInfoOperationCompleted;
            private System.Threading.SendOrPostCallback GetRaceInfoOperationCompleted;
            private System.Threading.SendOrPostCallback GetAllEventsOperationCompleted;
            private System.Threading.SendOrPostCallback GetAllEventsWAOperationCompleted;
            private System.Threading.SendOrPostCallback GetRaceEventsOperationCompleted;
            private System.Threading.SendOrPostCallback GetVideosOperationCompleted;
            private System.Threading.SendOrPostCallback GetContactOperationCompleted;
            private System.Threading.SendOrPostCallback GetVideosListOperationCompleted;
            private System.Threading.SendOrPostCallback GetVideosListNewOperationCompleted;
            private System.Threading.SendOrPostCallback GetVideosWAOperationCompleted;
            private System.Threading.SendOrPostCallback GetCalEventsOperationCompleted;
            private System.Threading.SendOrPostCallback GetAdOperationCompleted;
            private System.Threading.SendOrPostCallback GetPOHAdOperationCompleted;
            private System.Threading.SendOrPostCallback GetAdLocationOperationCompleted;
            private System.Threading.SendOrPostCallback ClickedAdOperationCompleted;
            private System.Threading.SendOrPostCallback GetChangedOperationCompleted;
            private System.Threading.SendOrPostCallback GetStallionsOperationCompleted;
            private System.Threading.SendOrPostCallback GetHorsesOperationCompleted;
            private System.Threading.SendOrPostCallback GetChangedMySqlRealOperationCompleted;
            private System.Threading.SendOrPostCallback GetChangedMySqlReal2OperationCompleted;
            private System.Threading.SendOrPostCallback GetChangedMySqlOperationCompleted;
            private System.Threading.SendOrPostCallback SavePOHBookmarkOperationCompleted;
            private System.Threading.SendOrPostCallback SaveRunOperationCompleted;
            private System.Threading.SendOrPostCallback GetSIOperationCompleted;
            private System.Threading.SendOrPostCallback GetPropDescOperationCompleted;
            private System.Threading.SendOrPostCallback GetViewsOperationCompleted;
            private System.Threading.SendOrPostCallback GetAdditionHomeCountOperationCompleted;
            private System.Threading.SendOrPostCallback AddActivityOperationCompleted;
            private System.Threading.SendOrPostCallback GetRatingOperationCompleted;
            private System.Threading.SendOrPostCallback getSavedRunsOperationCompleted;
            private System.Threading.SendOrPostCallback SaveRatingOperationCompleted;
            private System.Threading.SendOrPostCallback GetAdditionalImagesOperationCompleted;

            public Service1()
            {
                this.Url = "http://www.ret.bz/POH1/POHWSDS.asmx";
            }

            public Service1(string url)
            {
                this.Url = url;
            }

            public event GetProfileCompletedEventHandler GetProfileCompleted;
            public event GeneratePOHUnResCompletedEventHandler GeneratePOHUnResCompleted;
            public event UpdatePOHGPSCompletedEventHandler UpdatePOHGPSCompleted;
            public event GetPOHAdditionsCompletedEventHandler GetPOHAdditionsCompleted;
            public event GetPOHListingByIdCompletedEventHandler GetPOHListingByIdCompleted;
            public event GetImagesCompletedEventHandler GetImagesCompleted;
            public event GetPOHListingById_POHIDCompletedEventHandler GetPOHListingById_POHIDCompleted;
            public event GetBookmarksPOHCompletedEventHandler GetBookmarksPOHCompleted;
            public event GetPOHAllPreviewCompletedEventHandler GetPOHAllPreviewCompleted;
            public event GetPOHAllPreviewRECompletedEventHandler GetPOHAllPreviewRECompleted;
            public event GetEStallionsCompletedEventHandler GetEStallionsCompleted;
            public event GetPOHAllPreviewSearchCompletedEventHandler GetPOHAllPreviewSearchCompleted;
            public event GetPOHAllPreviewSearchRECompletedEventHandler GetPOHAllPreviewSearchRECompleted;
            public event GetPOHAllPreviewSearchREWebCompletedEventHandler GetPOHAllPreviewSearchREWebCompleted;
            public event GetPOHAllPreviewBetaCompletedEventHandler GetPOHAllPreviewBetaCompleted;
            public event GetPOHGeoCompletedEventHandler GetPOHGeoCompleted;
            public event GetPOHCitiesByAreaCompletedEventHandler GetPOHCitiesByAreaCompleted;
            public event GetPOHCitiesCompletedEventHandler GetPOHCitiesCompleted;
            public event GetPOHOpenDateCompletedEventHandler GetPOHOpenDateCompleted;
            public event GetPOHCompanyCompletedEventHandler GetPOHCompanyCompleted;
            public event GetPOHBuildersCompletedEventHandler GetPOHBuildersCompleted;
            public event GetPOHListingsCompletedEventHandler GetPOHListingsCompleted;
            public event GetTipSheetsCompletedEventHandler GetTipSheetsCompleted;
            public event GetOvernightsCompletedEventHandler GetOvernightsCompleted;
            public event GetSpIDCompletedEventHandler GetSpIDCompleted;
            public event GetFeaturedCompletedEventHandler GetFeaturedCompleted;
            public event GetFeaturedNewCompletedEventHandler GetFeaturedNewCompleted;
            public event GetStoryCompletedEventHandler GetStoryCompleted;
            public event GetCallByDateCompletedEventHandler GetCallByDateCompleted;
            public event GetRaceDatesCompletedEventHandler GetRaceDatesCompleted;
            public event GetVidsByDateCompletedEventHandler GetVidsByDateCompleted;
            public event GetRaceEntriesFromEQCompletedEventHandler GetRaceEntriesFromEQCompleted;
            public event GetUpcomingRacesListBUCompletedEventHandler GetUpcomingRacesListBUCompleted;
            public event GetHRSponsorCompletedEventHandler GetHRSponsorCompleted;
            public event GetHRSponsorListCompletedEventHandler GetHRSponsorListCompleted;
            public event GetUpcomingRacesListCompletedEventHandler GetUpcomingRacesListCompleted;
            public event GetUpcomingRacesListDBCompletedEventHandler GetUpcomingRacesListDBCompleted;
            public event GetResultsListCompletedEventHandler GetResultsListCompleted;
            public event GetResultsListV2CompletedEventHandler GetResultsListV2Completed;
            public event GetResultsListNewCompletedEventHandler GetResultsListNewCompleted;
            public event AlexTestCompletedEventHandler AlexTestCompleted;
            public event GetResultsListDBCompletedEventHandler GetResultsListDBCompleted;
            public event GetRacesFromEQCompletedEventHandler GetRacesFromEQCompleted;
            public event GetRaceResultsEntriesFromEQCompletedEventHandler GetRaceResultsEntriesFromEQCompleted;
            public event GetRacesResultsFromEQCompletedEventHandler GetRacesResultsFromEQCompleted;
            public event GetStakeDatesCompletedEventHandler GetStakeDatesCompleted;
            public event GetTrackCompletedEventHandler GetTrackCompleted;
            public event GetStakesInfoCompletedEventHandler GetStakesInfoCompleted;
            public event GetRaceInfoCompletedEventHandler GetRaceInfoCompleted;
            public event GetAllEventsCompletedEventHandler GetAllEventsCompleted;
            public event GetAllEventsWACompletedEventHandler GetAllEventsWACompleted;
            public event GetRaceEventsCompletedEventHandler GetRaceEventsCompleted;
            public event GetVideosCompletedEventHandler GetVideosCompleted;
            public event GetContactCompletedEventHandler GetContactCompleted;
            public event GetVideosListCompletedEventHandler GetVideosListCompleted;
            public event GetVideosListNewCompletedEventHandler GetVideosListNewCompleted;
            public event GetVideosWACompletedEventHandler GetVideosWACompleted;
            public event GetCalEventsCompletedEventHandler GetCalEventsCompleted;
            public event GetAdCompletedEventHandler GetAdCompleted;
            public event GetPOHAdCompletedEventHandler GetPOHAdCompleted;
            public event GetAdLocationCompletedEventHandler GetAdLocationCompleted;
            public event ClickedAdCompletedEventHandler ClickedAdCompleted;
            public event GetChangedCompletedEventHandler GetChangedCompleted;
            public event GetStallionsCompletedEventHandler GetStallionsCompleted;
            public event GetHorsesCompletedEventHandler GetHorsesCompleted;
            public event GetChangedMySqlRealCompletedEventHandler GetChangedMySqlRealCompleted;
            public event GetChangedMySqlReal2CompletedEventHandler GetChangedMySqlReal2Completed;
            public event GetChangedMySqlCompletedEventHandler GetChangedMySqlCompleted;
            public event SavePOHBookmarkCompletedEventHandler SavePOHBookmarkCompleted;
            public event SaveRunCompletedEventHandler SaveRunCompleted;
            public event GetSICompletedEventHandler GetSICompleted;
            public event GetPropDescCompletedEventHandler GetPropDescCompleted;
            public event GetViewsCompletedEventHandler GetViewsCompleted;
            public event GetAdditionHomeCountCompletedEventHandler GetAdditionHomeCountCompleted;
            public event AddActivityCompletedEventHandler AddActivityCompleted;
            public event GetRatingCompletedEventHandler GetRatingCompleted;
            public event getSavedRunsCompletedEventHandler getSavedRunsCompleted;
            public event SaveRatingCompletedEventHandler SaveRatingCompleted;
            public event GetAdditionalImagesCompletedEventHandler GetAdditionalImagesCompleted;

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetProfile", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public ProfileStuff GetProfile(int id)
            {
                object[] results = this.Invoke("GetProfile", new object[] { id });
                return ((ProfileStuff)(results[0]));
            }

            public System.IAsyncResult BeginGetProfile(int id, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetProfile", new object[] { id }, callback, asyncState);
            }

            public ProfileStuff EndGetProfile(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((ProfileStuff)(results[0]));
            }

            public void GetProfileAsync(int id)
            {
                this.GetProfileAsync(id, null);
            }

            public void GetProfileAsync(int id, object userState)
            {
                if ((this.GetProfileOperationCompleted == null))
                {
                    this.GetProfileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProfileCompleted);
                }
                this.InvokeAsync("GetProfile", new object[] {
                        id}, this.GetProfileOperationCompleted, userState);
            }

            private void OnGetProfileCompleted(object arg)
            {
                if ((this.GetProfileCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetProfileCompleted(this, new GetProfileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GeneratePOHUnRes", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public ListingPreview[] GeneratePOHUnRes(string pohID)
            {
                object[] results = this.Invoke("GeneratePOHUnRes", new object[] {
                        pohID});
                return ((ListingPreview[])(results[0]));
            }

            public System.IAsyncResult BeginGeneratePOHUnRes(string pohID, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GeneratePOHUnRes", new object[] {
                        pohID}, callback, asyncState);
            }

            public ListingPreview[] EndGeneratePOHUnRes(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((ListingPreview[])(results[0]));
            }

            public void GeneratePOHUnResAsync(string pohID)
            {
                this.GeneratePOHUnResAsync(pohID, null);
            }

            public void GeneratePOHUnResAsync(string pohID, object userState)
            {
                if ((this.GeneratePOHUnResOperationCompleted == null))
                {
                    this.GeneratePOHUnResOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGeneratePOHUnResCompleted);
                }
                this.InvokeAsync("GeneratePOHUnRes", new object[] {
                        pohID}, this.GeneratePOHUnResOperationCompleted, userState);
            }

            private void OnGeneratePOHUnResCompleted(object arg)
            {
                if ((this.GeneratePOHUnResCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GeneratePOHUnResCompleted(this, new GeneratePOHUnResCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/UpdatePOHGPS", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public void UpdatePOHGPS(string pohID, string HouseID, string Latitude, string Longitude)
            {
                this.Invoke("UpdatePOHGPS", new object[] {
                        pohID,
                        HouseID,
                        Latitude,
                        Longitude});
            }

            public System.IAsyncResult BeginUpdatePOHGPS(string pohID, string HouseID, string Latitude, string Longitude, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("UpdatePOHGPS", new object[] {
                        pohID,
                        HouseID,
                        Latitude,
                        Longitude}, callback, asyncState);
            }

            public void EndUpdatePOHGPS(System.IAsyncResult asyncResult)
            {
                this.EndInvoke(asyncResult);
            }

            public void UpdatePOHGPSAsync(string pohID, string HouseID, string Latitude, string Longitude)
            {
                this.UpdatePOHGPSAsync(pohID, HouseID, Latitude, Longitude, null);
            }

            public void UpdatePOHGPSAsync(string pohID, string HouseID, string Latitude, string Longitude, object userState)
            {
                if ((this.UpdatePOHGPSOperationCompleted == null))
                {
                    this.UpdatePOHGPSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdatePOHGPSCompleted);
                }
                this.InvokeAsync("UpdatePOHGPS", new object[] {
                        pohID,
                        HouseID,
                        Latitude,
                        Longitude}, this.UpdatePOHGPSOperationCompleted, userState);
            }

            private void OnUpdatePOHGPSCompleted(object arg)
            {
                if ((this.UpdatePOHGPSCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.UpdatePOHGPSCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHAdditions", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetPOHAdditions(string pohId)
            {
                object[] results = this.Invoke("GetPOHAdditions", new object[] {
                        pohId});
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHAdditions(string pohId, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHAdditions", new object[] {
                        pohId}, callback, asyncState);
            }

            public string[] EndGetPOHAdditions(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetPOHAdditionsAsync(string pohId)
            {
                this.GetPOHAdditionsAsync(pohId, null);
            }

            public void GetPOHAdditionsAsync(string pohId, object userState)
            {
                if ((this.GetPOHAdditionsOperationCompleted == null))
                {
                    this.GetPOHAdditionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHAdditionsCompleted);
                }
                this.InvokeAsync("GetPOHAdditions", new object[] {
                        pohId}, this.GetPOHAdditionsOperationCompleted, userState);
            }

            private void OnGetPOHAdditionsCompleted(object arg)
            {
                if ((this.GetPOHAdditionsCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHAdditionsCompleted(this, new GetPOHAdditionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHListingById", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public Listings GetPOHListingById(string Id)
            {
                object[] results = this.Invoke("GetPOHListingById", new object[] {
                        Id});
                return ((Listings)(results[0]));
            }

            public System.IAsyncResult BeginGetPOHListingById(string Id, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHListingById", new object[] {
                        Id}, callback, asyncState);
            }

            public Listings EndGetPOHListingById(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((Listings)(results[0]));
            }

            public void GetPOHListingByIdAsync(string Id)
            {
                this.GetPOHListingByIdAsync(Id, null);
            }

            public void GetPOHListingByIdAsync(string Id, object userState)
            {
                if ((this.GetPOHListingByIdOperationCompleted == null))
                {
                    this.GetPOHListingByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHListingByIdCompleted);
                }
                this.InvokeAsync("GetPOHListingById", new object[] {
                        Id}, this.GetPOHListingByIdOperationCompleted, userState);
            }

            private void OnGetPOHListingByIdCompleted(object arg)
            {
                if ((this.GetPOHListingByIdCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHListingByIdCompleted(this, new GetPOHListingByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetImages", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string GetImages(string POHID, string PropID, int which)
            {
                object[] results = this.Invoke("GetImages", new object[] {
                        POHID,
                        PropID,
                        which});
                return ((string)(results[0]));
            }

            public System.IAsyncResult BeginGetImages(string POHID, string PropID, int which, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetImages", new object[] {
                        POHID,
                        PropID,
                        which}, callback, asyncState);
            }

            public string EndGetImages(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string)(results[0]));
            }

            public void GetImagesAsync(string POHID, string PropID, int which)
            {
                this.GetImagesAsync(POHID, PropID, which, null);
            }

            public void GetImagesAsync(string POHID, string PropID, int which, object userState)
            {
                if ((this.GetImagesOperationCompleted == null))
                {
                    this.GetImagesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetImagesCompleted);
                }
                this.InvokeAsync("GetImages", new object[] {
                        POHID,
                        PropID,
                        which}, this.GetImagesOperationCompleted, userState);
            }

            private void OnGetImagesCompleted(object arg)
            {
                if ((this.GetImagesCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetImagesCompleted(this, new GetImagesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHListingById_POHID", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public Listings GetPOHListingById_POHID(string Id, string POHID)
            {
                object[] results = this.Invoke("GetPOHListingById_POHID", new object[] {
                        Id,
                        POHID});
                return ((Listings)(results[0]));
            }

            public System.IAsyncResult BeginGetPOHListingById_POHID(string Id, string POHID, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHListingById_POHID", new object[] {
                        Id,
                        POHID}, callback, asyncState);
            }

            public Listings EndGetPOHListingById_POHID(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((Listings)(results[0]));
            }

            public void GetPOHListingById_POHIDAsync(string Id, string POHID)
            {
                this.GetPOHListingById_POHIDAsync(Id, POHID, null);
            }

            public void GetPOHListingById_POHIDAsync(string Id, string POHID, object userState)
            {
                if ((this.GetPOHListingById_POHIDOperationCompleted == null))
                {
                    this.GetPOHListingById_POHIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHListingById_POHIDCompleted);
                }
                this.InvokeAsync("GetPOHListingById_POHID", new object[] {
                        Id,
                        POHID}, this.GetPOHListingById_POHIDOperationCompleted, userState);
            }

            private void OnGetPOHListingById_POHIDCompleted(object arg)
            {
                if ((this.GetPOHListingById_POHIDCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHListingById_POHIDCompleted(this, new GetPOHListingById_POHIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetBookmarksPOH", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public ListingPreview[] GetBookmarksPOH(string guid)
            {
                object[] results = this.Invoke("GetBookmarksPOH", new object[] {
                        guid});
                return ((ListingPreview[])(results[0]));
            }

            public System.IAsyncResult BeginGetBookmarksPOH(string guid, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetBookmarksPOH", new object[] {
                        guid}, callback, asyncState);
            }

            public ListingPreview[] EndGetBookmarksPOH(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((ListingPreview[])(results[0]));
            }

            public void GetBookmarksPOHAsync(string guid)
            {
                this.GetBookmarksPOHAsync(guid, null);
            }

            public void GetBookmarksPOHAsync(string guid, object userState)
            {
                if ((this.GetBookmarksPOHOperationCompleted == null))
                {
                    this.GetBookmarksPOHOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBookmarksPOHCompleted);
                }
                this.InvokeAsync("GetBookmarksPOH", new object[] {
                        guid}, this.GetBookmarksPOHOperationCompleted, userState);
            }

            private void OnGetBookmarksPOHCompleted(object arg)
            {
                if ((this.GetBookmarksPOHCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetBookmarksPOHCompleted(this, new GetBookmarksPOHCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHAllPreview", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public ListingPreview[] GetPOHAllPreview(string pohId, string field, string fieldValue)
            {
                object[] results = this.Invoke("GetPOHAllPreview", new object[] {
                        pohId,
                        field,
                        fieldValue});
                return ((ListingPreview[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHAllPreview(string pohId, string field, string fieldValue, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHAllPreview", new object[] {
                        pohId,
                        field,
                        fieldValue}, callback, asyncState);
            }

            public ListingPreview[] EndGetPOHAllPreview(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((ListingPreview[])(results[0]));
            }

            public void GetPOHAllPreviewAsync(string pohId, string field, string fieldValue)
            {
                this.GetPOHAllPreviewAsync(pohId, field, fieldValue, null);
            }

            public void GetPOHAllPreviewAsync(string pohId, string field, string fieldValue, object userState)
            {
                if ((this.GetPOHAllPreviewOperationCompleted == null))
                {
                    this.GetPOHAllPreviewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHAllPreviewCompleted);
                }
                this.InvokeAsync("GetPOHAllPreview", new object[] {
                        pohId,
                        field,
                        fieldValue}, this.GetPOHAllPreviewOperationCompleted, userState);
            }

            private void OnGetPOHAllPreviewCompleted(object arg)
            {
                if ((this.GetPOHAllPreviewCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHAllPreviewCompleted(this, new GetPOHAllPreviewCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHAllPreviewRE", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public ListingPreview[] GetPOHAllPreviewRE(string pohId, string field, string fieldValue, string area)
            {
                object[] results = this.Invoke("GetPOHAllPreviewRE", new object[] {
                        pohId,
                        field,
                        fieldValue,
                        area});
                return ((ListingPreview[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHAllPreviewRE(string pohId, string field, string fieldValue, string area, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHAllPreviewRE", new object[] {
                        pohId,
                        field,
                        fieldValue,
                        area}, callback, asyncState);
            }

            public ListingPreview[] EndGetPOHAllPreviewRE(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((ListingPreview[])(results[0]));
            }

            public void GetPOHAllPreviewREAsync(string pohId, string field, string fieldValue, string area)
            {
                this.GetPOHAllPreviewREAsync(pohId, field, fieldValue, area, null);
            }

            public void GetPOHAllPreviewREAsync(string pohId, string field, string fieldValue, string area, object userState)
            {
                if ((this.GetPOHAllPreviewREOperationCompleted == null))
                {
                    this.GetPOHAllPreviewREOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHAllPreviewRECompleted);
                }
                this.InvokeAsync("GetPOHAllPreviewRE", new object[] {
                        pohId,
                        field,
                        fieldValue,
                        area}, this.GetPOHAllPreviewREOperationCompleted, userState);
            }

            private void OnGetPOHAllPreviewRECompleted(object arg)
            {
                if ((this.GetPOHAllPreviewRECompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHAllPreviewRECompleted(this, new GetPOHAllPreviewRECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetEStallions", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public void GetEStallions()
            {
                this.Invoke("GetEStallions", new object[0]);
            }

            public System.IAsyncResult BeginGetEStallions(System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetEStallions", new object[0], callback, asyncState);
            }

            public void EndGetEStallions(System.IAsyncResult asyncResult)
            {
                this.EndInvoke(asyncResult);
            }

            public void GetEStallionsAsync()
            {
                this.GetEStallionsAsync(null);
            }

            public void GetEStallionsAsync(object userState)
            {
                if ((this.GetEStallionsOperationCompleted == null))
                {
                    this.GetEStallionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEStallionsCompleted);
                }
                this.InvokeAsync("GetEStallions", new object[0], this.GetEStallionsOperationCompleted, userState);
            }

            private void OnGetEStallionsCompleted(object arg)
            {
                if ((this.GetEStallionsCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetEStallionsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHAllPreviewSearch", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public ListingPreview[] GetPOHAllPreviewSearch(string pohId, string builder, string price, string hood, string city, string ammenities)
            {
                object[] results = this.Invoke("GetPOHAllPreviewSearch", new object[] {
                        pohId,
                        builder,
                        price,
                        hood,
                        city,
                        ammenities});
                return ((ListingPreview[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHAllPreviewSearch(string pohId, string builder, string price, string hood, string city, string ammenities, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHAllPreviewSearch", new object[] {
                        pohId,
                        builder,
                        price,
                        hood,
                        city,
                        ammenities}, callback, asyncState);
            }

            public ListingPreview[] EndGetPOHAllPreviewSearch(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((ListingPreview[])(results[0]));
            }

            public void GetPOHAllPreviewSearchAsync(string pohId, string builder, string price, string hood, string city, string ammenities)
            {
                this.GetPOHAllPreviewSearchAsync(pohId, builder, price, hood, city, ammenities, null);
            }

            public void GetPOHAllPreviewSearchAsync(string pohId, string builder, string price, string hood, string city, string ammenities, object userState)
            {
                if ((this.GetPOHAllPreviewSearchOperationCompleted == null))
                {
                    this.GetPOHAllPreviewSearchOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHAllPreviewSearchCompleted);
                }
                this.InvokeAsync("GetPOHAllPreviewSearch", new object[] {
                        pohId,
                        builder,
                        price,
                        hood,
                        city,
                        ammenities}, this.GetPOHAllPreviewSearchOperationCompleted, userState);
            }

            private void OnGetPOHAllPreviewSearchCompleted(object arg)
            {
                if ((this.GetPOHAllPreviewSearchCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHAllPreviewSearchCompleted(this, new GetPOHAllPreviewSearchCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHAllPreviewSearchRE", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public ListingPreview[] GetPOHAllPreviewSearchRE(string pohId, string dateOpen, string company, string price, string area, string city, string ammenities, string beds, string baths, string sf)
            {
                object[] results = this.Invoke("GetPOHAllPreviewSearchRE", new object[] {
                        pohId,
                        dateOpen,
                        company,
                        price,
                        area,
                        city,
                        ammenities,
                        beds,
                        baths,
                        sf});
                return ((ListingPreview[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHAllPreviewSearchRE(string pohId, string dateOpen, string company, string price, string area, string city, string ammenities, string beds, string baths, string sf, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHAllPreviewSearchRE", new object[] {
                        pohId,
                        dateOpen,
                        company,
                        price,
                        area,
                        city,
                        ammenities,
                        beds,
                        baths,
                        sf}, callback, asyncState);
            }

            public ListingPreview[] EndGetPOHAllPreviewSearchRE(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((ListingPreview[])(results[0]));
            }

            public void GetPOHAllPreviewSearchREAsync(string pohId, string dateOpen, string company, string price, string area, string city, string ammenities, string beds, string baths, string sf)
            {
                this.GetPOHAllPreviewSearchREAsync(pohId, dateOpen, company, price, area, city, ammenities, beds, baths, sf, null);
            }

            public void GetPOHAllPreviewSearchREAsync(string pohId, string dateOpen, string company, string price, string area, string city, string ammenities, string beds, string baths, string sf, object userState)
            {
                if ((this.GetPOHAllPreviewSearchREOperationCompleted == null))
                {
                    this.GetPOHAllPreviewSearchREOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHAllPreviewSearchRECompleted);
                }
                this.InvokeAsync("GetPOHAllPreviewSearchRE", new object[] {
                        pohId,
                        dateOpen,
                        company,
                        price,
                        area,
                        city,
                        ammenities,
                        beds,
                        baths,
                        sf}, this.GetPOHAllPreviewSearchREOperationCompleted, userState);
            }

            private void OnGetPOHAllPreviewSearchRECompleted(object arg)
            {
                if ((this.GetPOHAllPreviewSearchRECompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHAllPreviewSearchRECompleted(this, new GetPOHAllPreviewSearchRECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHAllPreviewSearchREWeb", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public ListingPreview[] GetPOHAllPreviewSearchREWeb(string pohId, string dateOpen, string company, string price, string area, string city, string ammenities, string beds, string baths, string sf)
            {
                object[] results = this.Invoke("GetPOHAllPreviewSearchREWeb", new object[] {
                        pohId,
                        dateOpen,
                        company,
                        price,
                        area,
                        city,
                        ammenities,
                        beds,
                        baths,
                        sf});
                return ((ListingPreview[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHAllPreviewSearchREWeb(string pohId, string dateOpen, string company, string price, string area, string city, string ammenities, string beds, string baths, string sf, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHAllPreviewSearchREWeb", new object[] {
                        pohId,
                        dateOpen,
                        company,
                        price,
                        area,
                        city,
                        ammenities,
                        beds,
                        baths,
                        sf}, callback, asyncState);
            }

            public ListingPreview[] EndGetPOHAllPreviewSearchREWeb(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((ListingPreview[])(results[0]));
            }

            public void GetPOHAllPreviewSearchREWebAsync(string pohId, string dateOpen, string company, string price, string area, string city, string ammenities, string beds, string baths, string sf)
            {
                this.GetPOHAllPreviewSearchREWebAsync(pohId, dateOpen, company, price, area, city, ammenities, beds, baths, sf, null);
            }

            public void GetPOHAllPreviewSearchREWebAsync(string pohId, string dateOpen, string company, string price, string area, string city, string ammenities, string beds, string baths, string sf, object userState)
            {
                if ((this.GetPOHAllPreviewSearchREWebOperationCompleted == null))
                {
                    this.GetPOHAllPreviewSearchREWebOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHAllPreviewSearchREWebCompleted);
                }
                this.InvokeAsync("GetPOHAllPreviewSearchREWeb", new object[] {
                        pohId,
                        dateOpen,
                        company,
                        price,
                        area,
                        city,
                        ammenities,
                        beds,
                        baths,
                        sf}, this.GetPOHAllPreviewSearchREWebOperationCompleted, userState);
            }

            private void OnGetPOHAllPreviewSearchREWebCompleted(object arg)
            {
                if ((this.GetPOHAllPreviewSearchREWebCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHAllPreviewSearchREWebCompleted(this, new GetPOHAllPreviewSearchREWebCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHAllPreviewBeta", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public ListingPreview[] GetPOHAllPreviewBeta(string pohId, string field, string fieldValue)
            {
                object[] results = this.Invoke("GetPOHAllPreviewBeta", new object[] {
                        pohId,
                        field,
                        fieldValue});
                return ((ListingPreview[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHAllPreviewBeta(string pohId, string field, string fieldValue, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHAllPreviewBeta", new object[] {
                        pohId,
                        field,
                        fieldValue}, callback, asyncState);
            }

            public ListingPreview[] EndGetPOHAllPreviewBeta(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((ListingPreview[])(results[0]));
            }

            public void GetPOHAllPreviewBetaAsync(string pohId, string field, string fieldValue)
            {
                this.GetPOHAllPreviewBetaAsync(pohId, field, fieldValue, null);
            }

            public void GetPOHAllPreviewBetaAsync(string pohId, string field, string fieldValue, object userState)
            {
                if ((this.GetPOHAllPreviewBetaOperationCompleted == null))
                {
                    this.GetPOHAllPreviewBetaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHAllPreviewBetaCompleted);
                }
                this.InvokeAsync("GetPOHAllPreviewBeta", new object[] {
                        pohId,
                        field,
                        fieldValue}, this.GetPOHAllPreviewBetaOperationCompleted, userState);
            }

            private void OnGetPOHAllPreviewBetaCompleted(object arg)
            {
                if ((this.GetPOHAllPreviewBetaCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHAllPreviewBetaCompleted(this, new GetPOHAllPreviewBetaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHGeo", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public ListingPreview[] GetPOHGeo(string pohId)
            {
                object[] results = this.Invoke("GetPOHGeo", new object[] {
                        pohId});
                return ((ListingPreview[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHGeo(string pohId, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHGeo", new object[] {
                        pohId}, callback, asyncState);
            }

            public ListingPreview[] EndGetPOHGeo(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((ListingPreview[])(results[0]));
            }

            public void GetPOHGeoAsync(string pohId)
            {
                this.GetPOHGeoAsync(pohId, null);
            }

            public void GetPOHGeoAsync(string pohId, object userState)
            {
                if ((this.GetPOHGeoOperationCompleted == null))
                {
                    this.GetPOHGeoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHGeoCompleted);
                }
                this.InvokeAsync("GetPOHGeo", new object[] {
                        pohId}, this.GetPOHGeoOperationCompleted, userState);
            }

            private void OnGetPOHGeoCompleted(object arg)
            {
                if ((this.GetPOHGeoCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHGeoCompleted(this, new GetPOHGeoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHCitiesByArea", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetPOHCitiesByArea(string pohId, string Area)
            {
                object[] results = this.Invoke("GetPOHCitiesByArea", new object[] {
                        pohId,
                        Area});
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHCitiesByArea(string pohId, string Area, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHCitiesByArea", new object[] {
                        pohId,
                        Area}, callback, asyncState);
            }

            public string[] EndGetPOHCitiesByArea(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetPOHCitiesByAreaAsync(string pohId, string Area)
            {
                this.GetPOHCitiesByAreaAsync(pohId, Area, null);
            }

            public void GetPOHCitiesByAreaAsync(string pohId, string Area, object userState)
            {
                if ((this.GetPOHCitiesByAreaOperationCompleted == null))
                {
                    this.GetPOHCitiesByAreaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHCitiesByAreaCompleted);
                }
                this.InvokeAsync("GetPOHCitiesByArea", new object[] {
                        pohId,
                        Area}, this.GetPOHCitiesByAreaOperationCompleted, userState);
            }

            private void OnGetPOHCitiesByAreaCompleted(object arg)
            {
                if ((this.GetPOHCitiesByAreaCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHCitiesByAreaCompleted(this, new GetPOHCitiesByAreaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHCities", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetPOHCities(string pohId)
            {
                object[] results = this.Invoke("GetPOHCities", new object[] {
                        pohId});
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHCities(string pohId, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHCities", new object[] {
                        pohId}, callback, asyncState);
            }

            public string[] EndGetPOHCities(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetPOHCitiesAsync(string pohId)
            {
                this.GetPOHCitiesAsync(pohId, null);
            }

            public void GetPOHCitiesAsync(string pohId, object userState)
            {
                if ((this.GetPOHCitiesOperationCompleted == null))
                {
                    this.GetPOHCitiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHCitiesCompleted);
                }
                this.InvokeAsync("GetPOHCities", new object[] {
                        pohId}, this.GetPOHCitiesOperationCompleted, userState);
            }

            private void OnGetPOHCitiesCompleted(object arg)
            {
                if ((this.GetPOHCitiesCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHCitiesCompleted(this, new GetPOHCitiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHOpenDate", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetPOHOpenDate(string pohId)
            {
                object[] results = this.Invoke("GetPOHOpenDate", new object[] {
                        pohId});
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHOpenDate(string pohId, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHOpenDate", new object[] {
                        pohId}, callback, asyncState);
            }

            public string[] EndGetPOHOpenDate(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetPOHOpenDateAsync(string pohId)
            {
                this.GetPOHOpenDateAsync(pohId, null);
            }

            public void GetPOHOpenDateAsync(string pohId, object userState)
            {
                if ((this.GetPOHOpenDateOperationCompleted == null))
                {
                    this.GetPOHOpenDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHOpenDateCompleted);
                }
                this.InvokeAsync("GetPOHOpenDate", new object[] {
                        pohId}, this.GetPOHOpenDateOperationCompleted, userState);
            }

            private void OnGetPOHOpenDateCompleted(object arg)
            {
                if ((this.GetPOHOpenDateCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHOpenDateCompleted(this, new GetPOHOpenDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHCompany", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetPOHCompany(string pohId)
            {
                object[] results = this.Invoke("GetPOHCompany", new object[] {
                        pohId});
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHCompany(string pohId, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHCompany", new object[] {
                        pohId}, callback, asyncState);
            }

            public string[] EndGetPOHCompany(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetPOHCompanyAsync(string pohId)
            {
                this.GetPOHCompanyAsync(pohId, null);
            }

            public void GetPOHCompanyAsync(string pohId, object userState)
            {
                if ((this.GetPOHCompanyOperationCompleted == null))
                {
                    this.GetPOHCompanyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHCompanyCompleted);
                }
                this.InvokeAsync("GetPOHCompany", new object[] {
                        pohId}, this.GetPOHCompanyOperationCompleted, userState);
            }

            private void OnGetPOHCompanyCompleted(object arg)
            {
                if ((this.GetPOHCompanyCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHCompanyCompleted(this, new GetPOHCompanyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHBuilders", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetPOHBuilders(string pohId)
            {
                object[] results = this.Invoke("GetPOHBuilders", new object[] {
                        pohId});
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHBuilders(string pohId, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHBuilders", new object[] {
                        pohId}, callback, asyncState);
            }

            public string[] EndGetPOHBuilders(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetPOHBuildersAsync(string pohId)
            {
                this.GetPOHBuildersAsync(pohId, null);
            }

            public void GetPOHBuildersAsync(string pohId, object userState)
            {
                if ((this.GetPOHBuildersOperationCompleted == null))
                {
                    this.GetPOHBuildersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHBuildersCompleted);
                }
                this.InvokeAsync("GetPOHBuilders", new object[] {
                        pohId}, this.GetPOHBuildersOperationCompleted, userState);
            }

            private void OnGetPOHBuildersCompleted(object arg)
            {
                if ((this.GetPOHBuildersCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHBuildersCompleted(this, new GetPOHBuildersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHListings", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public Listings[] GetPOHListings(string pohId, string field, string fieldValue)
            {
                object[] results = this.Invoke("GetPOHListings", new object[] {
                        pohId,
                        field,
                        fieldValue});
                return ((Listings[])(results[0]));
            }

            public System.IAsyncResult BeginGetPOHListings(string pohId, string field, string fieldValue, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHListings", new object[] {
                        pohId,
                        field,
                        fieldValue}, callback, asyncState);
            }

            public Listings[] EndGetPOHListings(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((Listings[])(results[0]));
            }

            public void GetPOHListingsAsync(string pohId, string field, string fieldValue)
            {
                this.GetPOHListingsAsync(pohId, field, fieldValue, null);
            }

            public void GetPOHListingsAsync(string pohId, string field, string fieldValue, object userState)
            {
                if ((this.GetPOHListingsOperationCompleted == null))
                {
                    this.GetPOHListingsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHListingsCompleted);
                }
                this.InvokeAsync("GetPOHListings", new object[] {
                        pohId,
                        field,
                        fieldValue}, this.GetPOHListingsOperationCompleted, userState);
            }

            private void OnGetPOHListingsCompleted(object arg)
            {
                if ((this.GetPOHListingsCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHListingsCompleted(this, new GetPOHListingsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetTipSheets", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string GetTipSheets()
            {
                object[] results = this.Invoke("GetTipSheets", new object[0]);
                return ((string)(results[0]));
            }

            public System.IAsyncResult BeginGetTipSheets(System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetTipSheets", new object[0], callback, asyncState);
            }

            public string EndGetTipSheets(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string)(results[0]));
            }

            public void GetTipSheetsAsync()
            {
                this.GetTipSheetsAsync(null);
            }

            public void GetTipSheetsAsync(object userState)
            {
                if ((this.GetTipSheetsOperationCompleted == null))
                {
                    this.GetTipSheetsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTipSheetsCompleted);
                }
                this.InvokeAsync("GetTipSheets", new object[0], this.GetTipSheetsOperationCompleted, userState);
            }

            private void OnGetTipSheetsCompleted(object arg)
            {
                if ((this.GetTipSheetsCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetTipSheetsCompleted(this, new GetTipSheetsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetOvernights", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string GetOvernights()
            {
                object[] results = this.Invoke("GetOvernights", new object[0]);
                return ((string)(results[0]));
            }

            public System.IAsyncResult BeginGetOvernights(System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetOvernights", new object[0], callback, asyncState);
            }

            public string EndGetOvernights(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string)(results[0]));
            }

            public void GetOvernightsAsync()
            {
                this.GetOvernightsAsync(null);
            }

            public void GetOvernightsAsync(object userState)
            {
                if ((this.GetOvernightsOperationCompleted == null))
                {
                    this.GetOvernightsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOvernightsCompleted);
                }
                this.InvokeAsync("GetOvernights", new object[0], this.GetOvernightsOperationCompleted, userState);
            }

            private void OnGetOvernightsCompleted(object arg)
            {
                if ((this.GetOvernightsCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetOvernightsCompleted(this, new GetOvernightsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetSpID", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string GetSpID(string regId)
            {
                object[] results = this.Invoke("GetSpID", new object[] {
                        regId});
                return ((string)(results[0]));
            }

            public System.IAsyncResult BeginGetSpID(string regId, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetSpID", new object[] {
                        regId}, callback, asyncState);
            }

            public string EndGetSpID(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string)(results[0]));
            }

            public void GetSpIDAsync(string regId)
            {
                this.GetSpIDAsync(regId, null);
            }

            public void GetSpIDAsync(string regId, object userState)
            {
                if ((this.GetSpIDOperationCompleted == null))
                {
                    this.GetSpIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSpIDCompleted);
                }
                this.InvokeAsync("GetSpID", new object[] {
                        regId}, this.GetSpIDOperationCompleted, userState);
            }

            private void OnGetSpIDCompleted(object arg)
            {
                if ((this.GetSpIDCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetSpIDCompleted(this, new GetSpIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetFeatured", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public FeatureInfo[] GetFeatured(int featType)
            {
                object[] results = this.Invoke("GetFeatured", new object[] {
                        featType});
                return ((FeatureInfo[])(results[0]));
            }

            public System.IAsyncResult BeginGetFeatured(int featType, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetFeatured", new object[] {
                        featType}, callback, asyncState);
            }

            public FeatureInfo[] EndGetFeatured(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((FeatureInfo[])(results[0]));
            }

            public void GetFeaturedAsync(int featType)
            {
                this.GetFeaturedAsync(featType, null);
            }

            public void GetFeaturedAsync(int featType, object userState)
            {
                if ((this.GetFeaturedOperationCompleted == null))
                {
                    this.GetFeaturedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFeaturedCompleted);
                }
                this.InvokeAsync("GetFeatured", new object[] {
                        featType}, this.GetFeaturedOperationCompleted, userState);
            }

            private void OnGetFeaturedCompleted(object arg)
            {
                if ((this.GetFeaturedCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetFeaturedCompleted(this, new GetFeaturedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetFeaturedNew", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public FeatureInfo[] GetFeaturedNew(int featType)
            {
                object[] results = this.Invoke("GetFeaturedNew", new object[] {
                        featType});
                return ((FeatureInfo[])(results[0]));
            }

            public System.IAsyncResult BeginGetFeaturedNew(int featType, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetFeaturedNew", new object[] {
                        featType}, callback, asyncState);
            }

            public FeatureInfo[] EndGetFeaturedNew(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((FeatureInfo[])(results[0]));
            }

            public void GetFeaturedNewAsync(int featType)
            {
                this.GetFeaturedNewAsync(featType, null);
            }

            public void GetFeaturedNewAsync(int featType, object userState)
            {
                if ((this.GetFeaturedNewOperationCompleted == null))
                {
                    this.GetFeaturedNewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFeaturedNewCompleted);
                }
                this.InvokeAsync("GetFeaturedNew", new object[] {
                        featType}, this.GetFeaturedNewOperationCompleted, userState);
            }

            private void OnGetFeaturedNewCompleted(object arg)
            {
                if ((this.GetFeaturedNewCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetFeaturedNewCompleted(this, new GetFeaturedNewCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetStory", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string GetStory(string id)
            {
                object[] results = this.Invoke("GetStory", new object[] {
                        id});
                return ((string)(results[0]));
            }

            public System.IAsyncResult BeginGetStory(string id, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetStory", new object[] {
                        id}, callback, asyncState);
            }

            public string EndGetStory(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string)(results[0]));
            }

            public void GetStoryAsync(string id)
            {
                this.GetStoryAsync(id, null);
            }

            public void GetStoryAsync(string id, object userState)
            {
                if ((this.GetStoryOperationCompleted == null))
                {
                    this.GetStoryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetStoryCompleted);
                }
                this.InvokeAsync("GetStory", new object[] {
                        id}, this.GetStoryOperationCompleted, userState);
            }

            private void OnGetStoryCompleted(object arg)
            {
                if ((this.GetStoryCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetStoryCompleted(this, new GetStoryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetCallByDate", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public RaceInfoFull[] GetCallByDate(string sDate)
            {
                object[] results = this.Invoke("GetCallByDate", new object[] {
                        sDate});
                return ((RaceInfoFull[])(results[0]));
            }

            public System.IAsyncResult BeginGetCallByDate(string sDate, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetCallByDate", new object[] {
                        sDate}, callback, asyncState);
            }

            public RaceInfoFull[] EndGetCallByDate(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((RaceInfoFull[])(results[0]));
            }

            public void GetCallByDateAsync(string sDate)
            {
                this.GetCallByDateAsync(sDate, null);
            }

            public void GetCallByDateAsync(string sDate, object userState)
            {
                if ((this.GetCallByDateOperationCompleted == null))
                {
                    this.GetCallByDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCallByDateCompleted);
                }
                this.InvokeAsync("GetCallByDate", new object[] {
                        sDate}, this.GetCallByDateOperationCompleted, userState);
            }

            private void OnGetCallByDateCompleted(object arg)
            {
                if ((this.GetCallByDateCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetCallByDateCompleted(this, new GetCallByDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetRaceDates", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string GetRaceDates()
            {
                object[] results = this.Invoke("GetRaceDates", new object[0]);
                return ((string)(results[0]));
            }

            public System.IAsyncResult BeginGetRaceDates(System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetRaceDates", new object[0], callback, asyncState);
            }

            public string EndGetRaceDates(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string)(results[0]));
            }

            public void GetRaceDatesAsync()
            {
                this.GetRaceDatesAsync(null);
            }

            public void GetRaceDatesAsync(object userState)
            {
                if ((this.GetRaceDatesOperationCompleted == null))
                {
                    this.GetRaceDatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRaceDatesCompleted);
                }
                this.InvokeAsync("GetRaceDates", new object[0], this.GetRaceDatesOperationCompleted, userState);
            }

            private void OnGetRaceDatesCompleted(object arg)
            {
                if ((this.GetRaceDatesCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetRaceDatesCompleted(this, new GetRaceDatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetVidsByDate", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public RaceInfoFull[] GetVidsByDate(string sDate, string track)
            {
                object[] results = this.Invoke("GetVidsByDate", new object[] {
                        sDate,
                        track});
                return ((RaceInfoFull[])(results[0]));
            }

            public System.IAsyncResult BeginGetVidsByDate(string sDate, string track, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetVidsByDate", new object[] {
                        sDate,
                        track}, callback, asyncState);
            }

            public RaceInfoFull[] EndGetVidsByDate(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((RaceInfoFull[])(results[0]));
            }

            public void GetVidsByDateAsync(string sDate, string track)
            {
                this.GetVidsByDateAsync(sDate, track, null);
            }

            public void GetVidsByDateAsync(string sDate, string track, object userState)
            {
                if ((this.GetVidsByDateOperationCompleted == null))
                {
                    this.GetVidsByDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetVidsByDateCompleted);
                }
                this.InvokeAsync("GetVidsByDate", new object[] {
                        sDate,
                        track}, this.GetVidsByDateOperationCompleted, userState);
            }

            private void OnGetVidsByDateCompleted(object arg)
            {
                if ((this.GetVidsByDateCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetVidsByDateCompleted(this, new GetVidsByDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetRaceEntriesFromEQ", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public RaceEntries[] GetRaceEntriesFromEQ(string track, string dateStr, string race, string DE)
            {
                object[] results = this.Invoke("GetRaceEntriesFromEQ", new object[] {
                        track,
                        dateStr,
                        race,
                        DE});
                return ((RaceEntries[])(results[0]));
            }

            public System.IAsyncResult BeginGetRaceEntriesFromEQ(string track, string dateStr, string race, string DE, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetRaceEntriesFromEQ", new object[] {
                        track,
                        dateStr,
                        race,
                        DE}, callback, asyncState);
            }

            public RaceEntries[] EndGetRaceEntriesFromEQ(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((RaceEntries[])(results[0]));
            }

            public void GetRaceEntriesFromEQAsync(string track, string dateStr, string race, string DE)
            {
                this.GetRaceEntriesFromEQAsync(track, dateStr, race, DE, null);
            }

            public void GetRaceEntriesFromEQAsync(string track, string dateStr, string race, string DE, object userState)
            {
                if ((this.GetRaceEntriesFromEQOperationCompleted == null))
                {
                    this.GetRaceEntriesFromEQOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRaceEntriesFromEQCompleted);
                }
                this.InvokeAsync("GetRaceEntriesFromEQ", new object[] {
                        track,
                        dateStr,
                        race,
                        DE}, this.GetRaceEntriesFromEQOperationCompleted, userState);
            }

            private void OnGetRaceEntriesFromEQCompleted(object arg)
            {
                if ((this.GetRaceEntriesFromEQCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetRaceEntriesFromEQCompleted(this, new GetRaceEntriesFromEQCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetUpcomingRacesListBU", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public UpcomingRaces[] GetUpcomingRacesListBU(string track)
            {
                object[] results = this.Invoke("GetUpcomingRacesListBU", new object[] {
                        track});
                return ((UpcomingRaces[])(results[0]));
            }

            public System.IAsyncResult BeginGetUpcomingRacesListBU(string track, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetUpcomingRacesListBU", new object[] {
                        track}, callback, asyncState);
            }

            public UpcomingRaces[] EndGetUpcomingRacesListBU(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((UpcomingRaces[])(results[0]));
            }

            public void GetUpcomingRacesListBUAsync(string track)
            {
                this.GetUpcomingRacesListBUAsync(track, null);
            }

            public void GetUpcomingRacesListBUAsync(string track, object userState)
            {
                if ((this.GetUpcomingRacesListBUOperationCompleted == null))
                {
                    this.GetUpcomingRacesListBUOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUpcomingRacesListBUCompleted);
                }
                this.InvokeAsync("GetUpcomingRacesListBU", new object[] {
                        track}, this.GetUpcomingRacesListBUOperationCompleted, userState);
            }

            private void OnGetUpcomingRacesListBUCompleted(object arg)
            {
                if ((this.GetUpcomingRacesListBUCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetUpcomingRacesListBUCompleted(this, new GetUpcomingRacesListBUCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetHRSponsor", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public Sponsors GetHRSponsor(string sponsorID)
            {
                object[] results = this.Invoke("GetHRSponsor", new object[] {
                        sponsorID});
                return ((Sponsors)(results[0]));
            }

            public System.IAsyncResult BeginGetHRSponsor(string sponsorID, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetHRSponsor", new object[] {
                        sponsorID}, callback, asyncState);
            }

            public Sponsors EndGetHRSponsor(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((Sponsors)(results[0]));
            }

            public void GetHRSponsorAsync(string sponsorID)
            {
                this.GetHRSponsorAsync(sponsorID, null);
            }

            public void GetHRSponsorAsync(string sponsorID, object userState)
            {
                if ((this.GetHRSponsorOperationCompleted == null))
                {
                    this.GetHRSponsorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetHRSponsorCompleted);
                }
                this.InvokeAsync("GetHRSponsor", new object[] {
                        sponsorID}, this.GetHRSponsorOperationCompleted, userState);
            }

            private void OnGetHRSponsorCompleted(object arg)
            {
                if ((this.GetHRSponsorCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetHRSponsorCompleted(this, new GetHRSponsorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetHRSponsorList", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public SponsorsList[] GetHRSponsorList(string sponsorType)
            {
                object[] results = this.Invoke("GetHRSponsorList", new object[] {
                        sponsorType});
                return ((SponsorsList[])(results[0]));
            }

            public System.IAsyncResult BeginGetHRSponsorList(string sponsorType, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetHRSponsorList", new object[] {
                        sponsorType}, callback, asyncState);
            }

            public SponsorsList[] EndGetHRSponsorList(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((SponsorsList[])(results[0]));
            }

            public void GetHRSponsorListAsync(string sponsorType)
            {
                this.GetHRSponsorListAsync(sponsorType, null);
            }

            public void GetHRSponsorListAsync(string sponsorType, object userState)
            {
                if ((this.GetHRSponsorListOperationCompleted == null))
                {
                    this.GetHRSponsorListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetHRSponsorListCompleted);
                }
                this.InvokeAsync("GetHRSponsorList", new object[] {
                        sponsorType}, this.GetHRSponsorListOperationCompleted, userState);
            }

            private void OnGetHRSponsorListCompleted(object arg)
            {
                if ((this.GetHRSponsorListCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetHRSponsorListCompleted(this, new GetHRSponsorListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetUpcomingRacesList", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public UpcomingRaces[] GetUpcomingRacesList(string track)
            {
                object[] results = this.Invoke("GetUpcomingRacesList", new object[] {
                        track});
                return ((UpcomingRaces[])(results[0]));
            }

            public System.IAsyncResult BeginGetUpcomingRacesList(string track, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetUpcomingRacesList", new object[] {
                        track}, callback, asyncState);
            }

            public UpcomingRaces[] EndGetUpcomingRacesList(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((UpcomingRaces[])(results[0]));
            }

            public void GetUpcomingRacesListAsync(string track)
            {
                this.GetUpcomingRacesListAsync(track, null);
            }

            public void GetUpcomingRacesListAsync(string track, object userState)
            {
                if ((this.GetUpcomingRacesListOperationCompleted == null))
                {
                    this.GetUpcomingRacesListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUpcomingRacesListCompleted);
                }
                this.InvokeAsync("GetUpcomingRacesList", new object[] {
                        track}, this.GetUpcomingRacesListOperationCompleted, userState);
            }

            private void OnGetUpcomingRacesListCompleted(object arg)
            {
                if ((this.GetUpcomingRacesListCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetUpcomingRacesListCompleted(this, new GetUpcomingRacesListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetUpcomingRacesListDB", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public UpcomingRaces[] GetUpcomingRacesListDB(string track)
            {
                object[] results = this.Invoke("GetUpcomingRacesListDB", new object[] {
                        track});
                return ((UpcomingRaces[])(results[0]));
            }

            public System.IAsyncResult BeginGetUpcomingRacesListDB(string track, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetUpcomingRacesListDB", new object[] {
                        track}, callback, asyncState);
            }

            public UpcomingRaces[] EndGetUpcomingRacesListDB(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((UpcomingRaces[])(results[0]));
            }

            public void GetUpcomingRacesListDBAsync(string track)
            {
                this.GetUpcomingRacesListDBAsync(track, null);
            }

            public void GetUpcomingRacesListDBAsync(string track, object userState)
            {
                if ((this.GetUpcomingRacesListDBOperationCompleted == null))
                {
                    this.GetUpcomingRacesListDBOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUpcomingRacesListDBCompleted);
                }
                this.InvokeAsync("GetUpcomingRacesListDB", new object[] {
                        track}, this.GetUpcomingRacesListDBOperationCompleted, userState);
            }

            private void OnGetUpcomingRacesListDBCompleted(object arg)
            {
                if ((this.GetUpcomingRacesListDBCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetUpcomingRacesListDBCompleted(this, new GetUpcomingRacesListDBCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetResultsList", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public UpcomingRaces[] GetResultsList(string track)
            {
                object[] results = this.Invoke("GetResultsList", new object[] {
                        track});
                return ((UpcomingRaces[])(results[0]));
            }

            public System.IAsyncResult BeginGetResultsList(string track, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetResultsList", new object[] {
                        track}, callback, asyncState);
            }

            public UpcomingRaces[] EndGetResultsList(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((UpcomingRaces[])(results[0]));
            }

            public void GetResultsListAsync(string track)
            {
                this.GetResultsListAsync(track, null);
            }

            public void GetResultsListAsync(string track, object userState)
            {
                if ((this.GetResultsListOperationCompleted == null))
                {
                    this.GetResultsListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetResultsListCompleted);
                }
                this.InvokeAsync("GetResultsList", new object[] {
                        track}, this.GetResultsListOperationCompleted, userState);
            }

            private void OnGetResultsListCompleted(object arg)
            {
                if ((this.GetResultsListCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetResultsListCompleted(this, new GetResultsListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetResultsListV2", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public UpcomingRaces[] GetResultsListV2(string track)
            {
                object[] results = this.Invoke("GetResultsListV2", new object[] {
                        track});
                return ((UpcomingRaces[])(results[0]));
            }

            public System.IAsyncResult BeginGetResultsListV2(string track, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetResultsListV2", new object[] {
                        track}, callback, asyncState);
            }

            public UpcomingRaces[] EndGetResultsListV2(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((UpcomingRaces[])(results[0]));
            }

            public void GetResultsListV2Async(string track)
            {
                this.GetResultsListV2Async(track, null);
            }

            public void GetResultsListV2Async(string track, object userState)
            {
                if ((this.GetResultsListV2OperationCompleted == null))
                {
                    this.GetResultsListV2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetResultsListV2Completed);
                }
                this.InvokeAsync("GetResultsListV2", new object[] {
                        track}, this.GetResultsListV2OperationCompleted, userState);
            }

            private void OnGetResultsListV2Completed(object arg)
            {
                if ((this.GetResultsListV2Completed != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetResultsListV2Completed(this, new GetResultsListV2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetResultsListNew", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public UpcomingRaces[] GetResultsListNew(string track)
            {
                object[] results = this.Invoke("GetResultsListNew", new object[] {
                        track});
                return ((UpcomingRaces[])(results[0]));
            }

            public System.IAsyncResult BeginGetResultsListNew(string track, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetResultsListNew", new object[] {
                        track}, callback, asyncState);
            }

            public UpcomingRaces[] EndGetResultsListNew(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((UpcomingRaces[])(results[0]));
            }

            public void GetResultsListNewAsync(string track)
            {
                this.GetResultsListNewAsync(track, null);
            }

            public void GetResultsListNewAsync(string track, object userState)
            {
                if ((this.GetResultsListNewOperationCompleted == null))
                {
                    this.GetResultsListNewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetResultsListNewCompleted);
                }
                this.InvokeAsync("GetResultsListNew", new object[] {
                        track}, this.GetResultsListNewOperationCompleted, userState);
            }

            private void OnGetResultsListNewCompleted(object arg)
            {
                if ((this.GetResultsListNewCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetResultsListNewCompleted(this, new GetResultsListNewCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/AlexTest", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public AlexClass AlexTest(string passMeSomething)
            {
                object[] results = this.Invoke("AlexTest", new object[] {
                        passMeSomething});
                return ((AlexClass)(results[0]));
            }

            public System.IAsyncResult BeginAlexTest(string passMeSomething, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("AlexTest", new object[] {
                        passMeSomething}, callback, asyncState);
            }

            public AlexClass EndAlexTest(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((AlexClass)(results[0]));
            }

            public void AlexTestAsync(string passMeSomething)
            {
                this.AlexTestAsync(passMeSomething, null);
            }

            public void AlexTestAsync(string passMeSomething, object userState)
            {
                if ((this.AlexTestOperationCompleted == null))
                {
                    this.AlexTestOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAlexTestCompleted);
                }
                this.InvokeAsync("AlexTest", new object[] {
                        passMeSomething}, this.AlexTestOperationCompleted, userState);
            }

            private void OnAlexTestCompleted(object arg)
            {
                if ((this.AlexTestCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.AlexTestCompleted(this, new AlexTestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetResultsListDB", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public UpcomingRaces[] GetResultsListDB(string track)
            {
                object[] results = this.Invoke("GetResultsListDB", new object[] {
                        track});
                return ((UpcomingRaces[])(results[0]));
            }

            public System.IAsyncResult BeginGetResultsListDB(string track, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetResultsListDB", new object[] {
                        track}, callback, asyncState);
            }

            public UpcomingRaces[] EndGetResultsListDB(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((UpcomingRaces[])(results[0]));
            }

            public void GetResultsListDBAsync(string track)
            {
                this.GetResultsListDBAsync(track, null);
            }

            public void GetResultsListDBAsync(string track, object userState)
            {
                if ((this.GetResultsListDBOperationCompleted == null))
                {
                    this.GetResultsListDBOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetResultsListDBCompleted);
                }
                this.InvokeAsync("GetResultsListDB", new object[] {
                        track}, this.GetResultsListDBOperationCompleted, userState);
            }

            private void OnGetResultsListDBCompleted(object arg)
            {
                if ((this.GetResultsListDBCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetResultsListDBCompleted(this, new GetResultsListDBCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetRacesFromEQ", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public Races[] GetRacesFromEQ(string track, string dateStr)
            {
                object[] results = this.Invoke("GetRacesFromEQ", new object[] {
                        track,
                        dateStr});
                return ((Races[])(results[0]));
            }

            public System.IAsyncResult BeginGetRacesFromEQ(string track, string dateStr, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetRacesFromEQ", new object[] {
                        track,
                        dateStr}, callback, asyncState);
            }

            public Races[] EndGetRacesFromEQ(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((Races[])(results[0]));
            }

            public void GetRacesFromEQAsync(string track, string dateStr)
            {
                this.GetRacesFromEQAsync(track, dateStr, null);
            }

            public void GetRacesFromEQAsync(string track, string dateStr, object userState)
            {
                if ((this.GetRacesFromEQOperationCompleted == null))
                {
                    this.GetRacesFromEQOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRacesFromEQCompleted);
                }
                this.InvokeAsync("GetRacesFromEQ", new object[] {
                        track,
                        dateStr}, this.GetRacesFromEQOperationCompleted, userState);
            }

            private void OnGetRacesFromEQCompleted(object arg)
            {
                if ((this.GetRacesFromEQCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetRacesFromEQCompleted(this, new GetRacesFromEQCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetRaceResultsEntriesFromEQ", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public RaceResults[] GetRaceResultsEntriesFromEQ(string track, string dateStr, string race, string DE)
            {
                object[] results = this.Invoke("GetRaceResultsEntriesFromEQ", new object[] {
                        track,
                        dateStr,
                        race,
                        DE});
                return ((RaceResults[])(results[0]));
            }

            public System.IAsyncResult BeginGetRaceResultsEntriesFromEQ(string track, string dateStr, string race, string DE, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetRaceResultsEntriesFromEQ", new object[] {
                        track,
                        dateStr,
                        race,
                        DE}, callback, asyncState);
            }

            public RaceResults[] EndGetRaceResultsEntriesFromEQ(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((RaceResults[])(results[0]));
            }

            public void GetRaceResultsEntriesFromEQAsync(string track, string dateStr, string race, string DE)
            {
                this.GetRaceResultsEntriesFromEQAsync(track, dateStr, race, DE, null);
            }

            public void GetRaceResultsEntriesFromEQAsync(string track, string dateStr, string race, string DE, object userState)
            {
                if ((this.GetRaceResultsEntriesFromEQOperationCompleted == null))
                {
                    this.GetRaceResultsEntriesFromEQOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRaceResultsEntriesFromEQCompleted);
                }
                this.InvokeAsync("GetRaceResultsEntriesFromEQ", new object[] {
                        track,
                        dateStr,
                        race,
                        DE}, this.GetRaceResultsEntriesFromEQOperationCompleted, userState);
            }

            private void OnGetRaceResultsEntriesFromEQCompleted(object arg)
            {
                if ((this.GetRaceResultsEntriesFromEQCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetRaceResultsEntriesFromEQCompleted(this, new GetRaceResultsEntriesFromEQCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetRacesResultsFromEQ", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public RacesResults[] GetRacesResultsFromEQ(string track, string strDate)
            {
                object[] results = this.Invoke("GetRacesResultsFromEQ", new object[] {
                        track,
                        strDate});
                return ((RacesResults[])(results[0]));
            }

            public System.IAsyncResult BeginGetRacesResultsFromEQ(string track, string strDate, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetRacesResultsFromEQ", new object[] {
                        track,
                        strDate}, callback, asyncState);
            }

            public RacesResults[] EndGetRacesResultsFromEQ(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((RacesResults[])(results[0]));
            }

            public void GetRacesResultsFromEQAsync(string track, string strDate)
            {
                this.GetRacesResultsFromEQAsync(track, strDate, null);
            }

            public void GetRacesResultsFromEQAsync(string track, string strDate, object userState)
            {
                if ((this.GetRacesResultsFromEQOperationCompleted == null))
                {
                    this.GetRacesResultsFromEQOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRacesResultsFromEQCompleted);
                }
                this.InvokeAsync("GetRacesResultsFromEQ", new object[] {
                        track,
                        strDate}, this.GetRacesResultsFromEQOperationCompleted, userState);
            }

            private void OnGetRacesResultsFromEQCompleted(object arg)
            {
                if ((this.GetRacesResultsFromEQCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetRacesResultsFromEQCompleted(this, new GetRacesResultsFromEQCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetStakeDates", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string GetStakeDates()
            {
                object[] results = this.Invoke("GetStakeDates", new object[0]);
                return ((string)(results[0]));
            }

            public System.IAsyncResult BeginGetStakeDates(System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetStakeDates", new object[0], callback, asyncState);
            }

            public string EndGetStakeDates(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string)(results[0]));
            }

            public void GetStakeDatesAsync()
            {
                this.GetStakeDatesAsync(null);
            }

            public void GetStakeDatesAsync(object userState)
            {
                if ((this.GetStakeDatesOperationCompleted == null))
                {
                    this.GetStakeDatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetStakeDatesCompleted);
                }
                this.InvokeAsync("GetStakeDates", new object[0], this.GetStakeDatesOperationCompleted, userState);
            }

            private void OnGetStakeDatesCompleted(object arg)
            {
                if ((this.GetStakeDatesCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetStakeDatesCompleted(this, new GetStakeDatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetTrack", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public Track GetTrack(string track)
            {
                object[] results = this.Invoke("GetTrack", new object[] {
                        track});
                return ((Track)(results[0]));
            }

            public System.IAsyncResult BeginGetTrack(string track, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetTrack", new object[] {
                        track}, callback, asyncState);
            }

            public Track EndGetTrack(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((Track)(results[0]));
            }

            public void GetTrackAsync(string track)
            {
                this.GetTrackAsync(track, null);
            }

            public void GetTrackAsync(string track, object userState)
            {
                if ((this.GetTrackOperationCompleted == null))
                {
                    this.GetTrackOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTrackCompleted);
                }
                this.InvokeAsync("GetTrack", new object[] {
                        track}, this.GetTrackOperationCompleted, userState);
            }

            private void OnGetTrackCompleted(object arg)
            {
                if ((this.GetTrackCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetTrackCompleted(this, new GetTrackCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetStakesInfo", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public StakesInfo[] GetStakesInfo(string rt, string dt, string grade, string age, string breed, string sex, string distance)
            {
                object[] results = this.Invoke("GetStakesInfo", new object[] {
                        rt,
                        dt,
                        grade,
                        age,
                        breed,
                        sex,
                        distance});
                return ((StakesInfo[])(results[0]));
            }

            public System.IAsyncResult BeginGetStakesInfo(string rt, string dt, string grade, string age, string breed, string sex, string distance, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetStakesInfo", new object[] {
                        rt,
                        dt,
                        grade,
                        age,
                        breed,
                        sex,
                        distance}, callback, asyncState);
            }

            public StakesInfo[] EndGetStakesInfo(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((StakesInfo[])(results[0]));
            }

            public void GetStakesInfoAsync(string rt, string dt, string grade, string age, string breed, string sex, string distance)
            {
                this.GetStakesInfoAsync(rt, dt, grade, age, breed, sex, distance, null);
            }

            public void GetStakesInfoAsync(string rt, string dt, string grade, string age, string breed, string sex, string distance, object userState)
            {
                if ((this.GetStakesInfoOperationCompleted == null))
                {
                    this.GetStakesInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetStakesInfoCompleted);
                }
                this.InvokeAsync("GetStakesInfo", new object[] {
                        rt,
                        dt,
                        grade,
                        age,
                        breed,
                        sex,
                        distance}, this.GetStakesInfoOperationCompleted, userState);
            }

            private void OnGetStakesInfoCompleted(object arg)
            {
                if ((this.GetStakesInfoCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetStakesInfoCompleted(this, new GetStakesInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetRaceInfo", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetRaceInfo(string id)
            {
                object[] results = this.Invoke("GetRaceInfo", new object[] {
                        id});
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetRaceInfo(string id, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetRaceInfo", new object[] {
                        id}, callback, asyncState);
            }

            public string[] EndGetRaceInfo(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetRaceInfoAsync(string id)
            {
                this.GetRaceInfoAsync(id, null);
            }

            public void GetRaceInfoAsync(string id, object userState)
            {
                if ((this.GetRaceInfoOperationCompleted == null))
                {
                    this.GetRaceInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRaceInfoCompleted);
                }
                this.InvokeAsync("GetRaceInfo", new object[] {
                        id}, this.GetRaceInfoOperationCompleted, userState);
            }

            private void OnGetRaceInfoCompleted(object arg)
            {
                if ((this.GetRaceInfoCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetRaceInfoCompleted(this, new GetRaceInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetAllEvents", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetAllEvents()
            {
                object[] results = this.Invoke("GetAllEvents", new object[0]);
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetAllEvents(System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetAllEvents", new object[0], callback, asyncState);
            }

            public string[] EndGetAllEvents(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetAllEventsAsync()
            {
                this.GetAllEventsAsync(null);
            }

            public void GetAllEventsAsync(object userState)
            {
                if ((this.GetAllEventsOperationCompleted == null))
                {
                    this.GetAllEventsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllEventsCompleted);
                }
                this.InvokeAsync("GetAllEvents", new object[0], this.GetAllEventsOperationCompleted, userState);
            }

            private void OnGetAllEventsCompleted(object arg)
            {
                if ((this.GetAllEventsCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetAllEventsCompleted(this, new GetAllEventsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetAllEventsWA", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public EventsList[] GetAllEventsWA()
            {
                object[] results = this.Invoke("GetAllEventsWA", new object[0]);
                return ((EventsList[])(results[0]));
            }

            public System.IAsyncResult BeginGetAllEventsWA(System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetAllEventsWA", new object[0], callback, asyncState);
            }

            public EventsList[] EndGetAllEventsWA(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((EventsList[])(results[0]));
            }

            public void GetAllEventsWAAsync()
            {
                this.GetAllEventsWAAsync(null);
            }

            public void GetAllEventsWAAsync(object userState)
            {
                if ((this.GetAllEventsWAOperationCompleted == null))
                {
                    this.GetAllEventsWAOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllEventsWACompleted);
                }
                this.InvokeAsync("GetAllEventsWA", new object[0], this.GetAllEventsWAOperationCompleted, userState);
            }

            private void OnGetAllEventsWACompleted(object arg)
            {
                if ((this.GetAllEventsWACompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetAllEventsWACompleted(this, new GetAllEventsWACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetRaceEvents", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetRaceEvents()
            {
                object[] results = this.Invoke("GetRaceEvents", new object[0]);
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetRaceEvents(System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetRaceEvents", new object[0], callback, asyncState);
            }

            public string[] EndGetRaceEvents(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetRaceEventsAsync()
            {
                this.GetRaceEventsAsync(null);
            }

            public void GetRaceEventsAsync(object userState)
            {
                if ((this.GetRaceEventsOperationCompleted == null))
                {
                    this.GetRaceEventsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRaceEventsCompleted);
                }
                this.InvokeAsync("GetRaceEvents", new object[0], this.GetRaceEventsOperationCompleted, userState);
            }

            private void OnGetRaceEventsCompleted(object arg)
            {
                if ((this.GetRaceEventsCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetRaceEventsCompleted(this, new GetRaceEventsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetVideos", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetVideos(string track, string startDate)
            {
                object[] results = this.Invoke("GetVideos", new object[] {
                        track,
                        startDate});
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetVideos(string track, string startDate, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetVideos", new object[] {
                        track,
                        startDate}, callback, asyncState);
            }

            public string[] EndGetVideos(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetVideosAsync(string track, string startDate)
            {
                this.GetVideosAsync(track, startDate, null);
            }

            public void GetVideosAsync(string track, string startDate, object userState)
            {
                if ((this.GetVideosOperationCompleted == null))
                {
                    this.GetVideosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetVideosCompleted);
                }
                this.InvokeAsync("GetVideos", new object[] {
                        track,
                        startDate}, this.GetVideosOperationCompleted, userState);
            }

            private void OnGetVideosCompleted(object arg)
            {
                if ((this.GetVideosCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetVideosCompleted(this, new GetVideosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetContact", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string GetContact(string which)
            {
                object[] results = this.Invoke("GetContact", new object[] {
                        which});
                return ((string)(results[0]));
            }

            public System.IAsyncResult BeginGetContact(string which, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetContact", new object[] {
                        which}, callback, asyncState);
            }

            public string EndGetContact(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string)(results[0]));
            }

            public void GetContactAsync(string which)
            {
                this.GetContactAsync(which, null);
            }

            public void GetContactAsync(string which, object userState)
            {
                if ((this.GetContactOperationCompleted == null))
                {
                    this.GetContactOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetContactCompleted);
                }
                this.InvokeAsync("GetContact", new object[] {
                        which}, this.GetContactOperationCompleted, userState);
            }

            private void OnGetContactCompleted(object arg)
            {
                if ((this.GetContactCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetContactCompleted(this, new GetContactCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetVideosList", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public VideoDates[] GetVideosList(string track, string startDate)
            {
                object[] results = this.Invoke("GetVideosList", new object[] {
                        track,
                        startDate});
                return ((VideoDates[])(results[0]));
            }

            public System.IAsyncResult BeginGetVideosList(string track, string startDate, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetVideosList", new object[] {
                        track,
                        startDate}, callback, asyncState);
            }

            public VideoDates[] EndGetVideosList(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((VideoDates[])(results[0]));
            }

            public void GetVideosListAsync(string track, string startDate)
            {
                this.GetVideosListAsync(track, startDate, null);
            }

            public void GetVideosListAsync(string track, string startDate, object userState)
            {
                if ((this.GetVideosListOperationCompleted == null))
                {
                    this.GetVideosListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetVideosListCompleted);
                }
                this.InvokeAsync("GetVideosList", new object[] {
                        track,
                        startDate}, this.GetVideosListOperationCompleted, userState);
            }

            private void OnGetVideosListCompleted(object arg)
            {
                if ((this.GetVideosListCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetVideosListCompleted(this, new GetVideosListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetVideosListNew", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public VideoDates[] GetVideosListNew(string track, string startDate)
            {
                object[] results = this.Invoke("GetVideosListNew", new object[] {
                        track,
                        startDate});
                return ((VideoDates[])(results[0]));
            }

            public System.IAsyncResult BeginGetVideosListNew(string track, string startDate, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetVideosListNew", new object[] {
                        track,
                        startDate}, callback, asyncState);
            }

            public VideoDates[] EndGetVideosListNew(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((VideoDates[])(results[0]));
            }

            public void GetVideosListNewAsync(string track, string startDate)
            {
                this.GetVideosListNewAsync(track, startDate, null);
            }

            public void GetVideosListNewAsync(string track, string startDate, object userState)
            {
                if ((this.GetVideosListNewOperationCompleted == null))
                {
                    this.GetVideosListNewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetVideosListNewCompleted);
                }
                this.InvokeAsync("GetVideosListNew", new object[] {
                        track,
                        startDate}, this.GetVideosListNewOperationCompleted, userState);
            }

            private void OnGetVideosListNewCompleted(object arg)
            {
                if ((this.GetVideosListNewCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetVideosListNewCompleted(this, new GetVideosListNewCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetVideosWA", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public Videos[] GetVideosWA(string track, string startDate)
            {
                object[] results = this.Invoke("GetVideosWA", new object[] {
                        track,
                        startDate});
                return ((Videos[])(results[0]));
            }

            public System.IAsyncResult BeginGetVideosWA(string track, string startDate, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetVideosWA", new object[] {
                        track,
                        startDate}, callback, asyncState);
            }

            public Videos[] EndGetVideosWA(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((Videos[])(results[0]));
            }

            public void GetVideosWAAsync(string track, string startDate)
            {
                this.GetVideosWAAsync(track, startDate, null);
            }

            public void GetVideosWAAsync(string track, string startDate, object userState)
            {
                if ((this.GetVideosWAOperationCompleted == null))
                {
                    this.GetVideosWAOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetVideosWACompleted);
                }
                this.InvokeAsync("GetVideosWA", new object[] {
                        track,
                        startDate}, this.GetVideosWAOperationCompleted, userState);
            }

            private void OnGetVideosWACompleted(object arg)
            {
                if ((this.GetVideosWACompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetVideosWACompleted(this, new GetVideosWACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetCalEvents", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetCalEvents()
            {
                object[] results = this.Invoke("GetCalEvents", new object[0]);
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetCalEvents(System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetCalEvents", new object[0], callback, asyncState);
            }

            public string[] EndGetCalEvents(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetCalEventsAsync()
            {
                this.GetCalEventsAsync(null);
            }

            public void GetCalEventsAsync(object userState)
            {
                if ((this.GetCalEventsOperationCompleted == null))
                {
                    this.GetCalEventsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCalEventsCompleted);
                }
                this.InvokeAsync("GetCalEvents", new object[0], this.GetCalEventsOperationCompleted, userState);
            }

            private void OnGetCalEventsCompleted(object arg)
            {
                if ((this.GetCalEventsCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetCalEventsCompleted(this, new GetCalEventsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetAd", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string GetAd(string AdType)
            {
                object[] results = this.Invoke("GetAd", new object[] {
                        AdType});
                return ((string)(results[0]));
            }

            public System.IAsyncResult BeginGetAd(string AdType, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetAd", new object[] {
                        AdType}, callback, asyncState);
            }

            public string EndGetAd(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string)(results[0]));
            }

            public void GetAdAsync(string AdType)
            {
                this.GetAdAsync(AdType, null);
            }

            public void GetAdAsync(string AdType, object userState)
            {
                if ((this.GetAdOperationCompleted == null))
                {
                    this.GetAdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAdCompleted);
                }
                this.InvokeAsync("GetAd", new object[] {
                        AdType}, this.GetAdOperationCompleted, userState);
            }

            private void OnGetAdCompleted(object arg)
            {
                if ((this.GetAdCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetAdCompleted(this, new GetAdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPOHAd", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string GetPOHAd(string AdType, string POHID)
            {
                object[] results = this.Invoke("GetPOHAd", new object[] {
                        AdType,
                        POHID});
                return ((string)(results[0]));
            }

            public System.IAsyncResult BeginGetPOHAd(string AdType, string POHID, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPOHAd", new object[] {
                        AdType,
                        POHID}, callback, asyncState);
            }

            public string EndGetPOHAd(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string)(results[0]));
            }

            public void GetPOHAdAsync(string AdType, string POHID)
            {
                this.GetPOHAdAsync(AdType, POHID, null);
            }

            public void GetPOHAdAsync(string AdType, string POHID, object userState)
            {
                if ((this.GetPOHAdOperationCompleted == null))
                {
                    this.GetPOHAdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPOHAdCompleted);
                }
                this.InvokeAsync("GetPOHAd", new object[] {
                        AdType,
                        POHID}, this.GetPOHAdOperationCompleted, userState);
            }

            private void OnGetPOHAdCompleted(object arg)
            {
                if ((this.GetPOHAdCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPOHAdCompleted(this, new GetPOHAdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetAdLocation", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string GetAdLocation(string Address)
            {
                object[] results = this.Invoke("GetAdLocation", new object[] {
                        Address});
                return ((string)(results[0]));
            }

            public System.IAsyncResult BeginGetAdLocation(string Address, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetAdLocation", new object[] {
                        Address}, callback, asyncState);
            }

            public string EndGetAdLocation(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string)(results[0]));
            }

            public void GetAdLocationAsync(string Address)
            {
                this.GetAdLocationAsync(Address, null);
            }

            public void GetAdLocationAsync(string Address, object userState)
            {
                if ((this.GetAdLocationOperationCompleted == null))
                {
                    this.GetAdLocationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAdLocationCompleted);
                }
                this.InvokeAsync("GetAdLocation", new object[] {
                        Address}, this.GetAdLocationOperationCompleted, userState);
            }

            private void OnGetAdLocationCompleted(object arg)
            {
                if ((this.GetAdLocationCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetAdLocationCompleted(this, new GetAdLocationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/ClickedAd", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public void ClickedAd()
            {
                this.Invoke("ClickedAd", new object[0]);
            }

            public System.IAsyncResult BeginClickedAd(System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("ClickedAd", new object[0], callback, asyncState);
            }

            public void EndClickedAd(System.IAsyncResult asyncResult)
            {
                this.EndInvoke(asyncResult);
            }

            public void ClickedAdAsync()
            {
                this.ClickedAdAsync(null);
            }

            public void ClickedAdAsync(object userState)
            {
                if ((this.ClickedAdOperationCompleted == null))
                {
                    this.ClickedAdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnClickedAdCompleted);
                }
                this.InvokeAsync("ClickedAd", new object[0], this.ClickedAdOperationCompleted, userState);
            }

            private void OnClickedAdCompleted(object arg)
            {
                if ((this.ClickedAdCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.ClickedAdCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetChanged", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetChanged(string DateString, bool FirstRun)
            {
                object[] results = this.Invoke("GetChanged", new object[] {
                        DateString,
                        FirstRun});
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetChanged(string DateString, bool FirstRun, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetChanged", new object[] {
                        DateString,
                        FirstRun}, callback, asyncState);
            }

            public string[] EndGetChanged(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetChangedAsync(string DateString, bool FirstRun)
            {
                this.GetChangedAsync(DateString, FirstRun, null);
            }

            public void GetChangedAsync(string DateString, bool FirstRun, object userState)
            {
                if ((this.GetChangedOperationCompleted == null))
                {
                    this.GetChangedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetChangedCompleted);
                }
                this.InvokeAsync("GetChanged", new object[] {
                        DateString,
                        FirstRun}, this.GetChangedOperationCompleted, userState);
            }

            private void OnGetChangedCompleted(object arg)
            {
                if ((this.GetChangedCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetChangedCompleted(this, new GetChangedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetStallions", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public eStallionMember[] GetStallions()
            {
                object[] results = this.Invoke("GetStallions", new object[0]);
                return ((eStallionMember[])(results[0]));
            }

            public System.IAsyncResult BeginGetStallions(System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetStallions", new object[0], callback, asyncState);
            }

            public eStallionMember[] EndGetStallions(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((eStallionMember[])(results[0]));
            }

            public void GetStallionsAsync()
            {
                this.GetStallionsAsync(null);
            }

            public void GetStallionsAsync(object userState)
            {
                if ((this.GetStallionsOperationCompleted == null))
                {
                    this.GetStallionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetStallionsCompleted);
                }
                this.InvokeAsync("GetStallions", new object[0], this.GetStallionsOperationCompleted, userState);
            }

            private void OnGetStallionsCompleted(object arg)
            {
                if ((this.GetStallionsCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetStallionsCompleted(this, new GetStallionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetHorses", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public eStallionMember[] GetHorses()
            {
                object[] results = this.Invoke("GetHorses", new object[0]);
                return ((eStallionMember[])(results[0]));
            }

            public System.IAsyncResult BeginGetHorses(System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetHorses", new object[0], callback, asyncState);
            }

            public eStallionMember[] EndGetHorses(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((eStallionMember[])(results[0]));
            }

            public void GetHorsesAsync()
            {
                this.GetHorsesAsync(null);
            }

            public void GetHorsesAsync(object userState)
            {
                if ((this.GetHorsesOperationCompleted == null))
                {
                    this.GetHorsesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetHorsesCompleted);
                }
                this.InvokeAsync("GetHorses", new object[0], this.GetHorsesOperationCompleted, userState);
            }

            private void OnGetHorsesCompleted(object arg)
            {
                if ((this.GetHorsesCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetHorsesCompleted(this, new GetHorsesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetChangedMySqlReal", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetChangedMySqlReal(string POHID, string DateString, bool FirstRun)
            {
                object[] results = this.Invoke("GetChangedMySqlReal", new object[] {
                        POHID,
                        DateString,
                        FirstRun});
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetChangedMySqlReal(string POHID, string DateString, bool FirstRun, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetChangedMySqlReal", new object[] {
                        POHID,
                        DateString,
                        FirstRun}, callback, asyncState);
            }

            public string[] EndGetChangedMySqlReal(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetChangedMySqlRealAsync(string POHID, string DateString, bool FirstRun)
            {
                this.GetChangedMySqlRealAsync(POHID, DateString, FirstRun, null);
            }

            public void GetChangedMySqlRealAsync(string POHID, string DateString, bool FirstRun, object userState)
            {
                if ((this.GetChangedMySqlRealOperationCompleted == null))
                {
                    this.GetChangedMySqlRealOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetChangedMySqlRealCompleted);
                }
                this.InvokeAsync("GetChangedMySqlReal", new object[] {
                        POHID,
                        DateString,
                        FirstRun}, this.GetChangedMySqlRealOperationCompleted, userState);
            }

            private void OnGetChangedMySqlRealCompleted(object arg)
            {
                if ((this.GetChangedMySqlRealCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetChangedMySqlRealCompleted(this, new GetChangedMySqlRealCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetChangedMySqlReal2", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetChangedMySqlReal2(string POHID, string DateString, bool FirstRun)
            {
                object[] results = this.Invoke("GetChangedMySqlReal2", new object[] {
                        POHID,
                        DateString,
                        FirstRun});
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetChangedMySqlReal2(string POHID, string DateString, bool FirstRun, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetChangedMySqlReal2", new object[] {
                        POHID,
                        DateString,
                        FirstRun}, callback, asyncState);
            }

            public string[] EndGetChangedMySqlReal2(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetChangedMySqlReal2Async(string POHID, string DateString, bool FirstRun)
            {
                this.GetChangedMySqlReal2Async(POHID, DateString, FirstRun, null);
            }

            public void GetChangedMySqlReal2Async(string POHID, string DateString, bool FirstRun, object userState)
            {
                if ((this.GetChangedMySqlReal2OperationCompleted == null))
                {
                    this.GetChangedMySqlReal2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetChangedMySqlReal2Completed);
                }
                this.InvokeAsync("GetChangedMySqlReal2", new object[] {
                        POHID,
                        DateString,
                        FirstRun}, this.GetChangedMySqlReal2OperationCompleted, userState);
            }

            private void OnGetChangedMySqlReal2Completed(object arg)
            {
                if ((this.GetChangedMySqlReal2Completed != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetChangedMySqlReal2Completed(this, new GetChangedMySqlReal2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetChangedMySql", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetChangedMySql(string DateString, bool FirstRun)
            {
                object[] results = this.Invoke("GetChangedMySql", new object[] {
                        DateString,
                        FirstRun});
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetChangedMySql(string DateString, bool FirstRun, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetChangedMySql", new object[] {
                        DateString,
                        FirstRun}, callback, asyncState);
            }

            public string[] EndGetChangedMySql(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetChangedMySqlAsync(string DateString, bool FirstRun)
            {
                this.GetChangedMySqlAsync(DateString, FirstRun, null);
            }

            public void GetChangedMySqlAsync(string DateString, bool FirstRun, object userState)
            {
                if ((this.GetChangedMySqlOperationCompleted == null))
                {
                    this.GetChangedMySqlOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetChangedMySqlCompleted);
                }
                this.InvokeAsync("GetChangedMySql", new object[] {
                        DateString,
                        FirstRun}, this.GetChangedMySqlOperationCompleted, userState);
            }

            private void OnGetChangedMySqlCompleted(object arg)
            {
                if ((this.GetChangedMySqlCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetChangedMySqlCompleted(this, new GetChangedMySqlCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/SavePOHBookmark", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public bool SavePOHBookmark(string guid, string id, string POHID)
            {
                object[] results = this.Invoke("SavePOHBookmark", new object[] {
                        guid,
                        id,
                        POHID});
                return ((bool)(results[0]));
            }

            public System.IAsyncResult BeginSavePOHBookmark(string guid, string id, string POHID, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("SavePOHBookmark", new object[] {
                        guid,
                        id,
                        POHID}, callback, asyncState);
            }

            public bool EndSavePOHBookmark(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((bool)(results[0]));
            }

            public void SavePOHBookmarkAsync(string guid, string id, string POHID)
            {
                this.SavePOHBookmarkAsync(guid, id, POHID, null);
            }

            public void SavePOHBookmarkAsync(string guid, string id, string POHID, object userState)
            {
                if ((this.SavePOHBookmarkOperationCompleted == null))
                {
                    this.SavePOHBookmarkOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSavePOHBookmarkCompleted);
                }
                this.InvokeAsync("SavePOHBookmark", new object[] {
                        guid,
                        id,
                        POHID}, this.SavePOHBookmarkOperationCompleted, userState);
            }

            private void OnSavePOHBookmarkCompleted(object arg)
            {
                if ((this.SavePOHBookmarkCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.SavePOHBookmarkCompleted(this, new SavePOHBookmarkCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/SaveRun", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public bool SaveRun(string guid, string horsename, string trackName, string dateRan, string timeran, float si, string distance)
            {
                object[] results = this.Invoke("SaveRun", new object[] {
                        guid,
                        horsename,
                        trackName,
                        dateRan,
                        timeran,
                        si,
                        distance});
                return ((bool)(results[0]));
            }

            public System.IAsyncResult BeginSaveRun(string guid, string horsename, string trackName, string dateRan, string timeran, float si, string distance, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("SaveRun", new object[] {
                        guid,
                        horsename,
                        trackName,
                        dateRan,
                        timeran,
                        si,
                        distance}, callback, asyncState);
            }

            public bool EndSaveRun(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((bool)(results[0]));
            }

            public void SaveRunAsync(string guid, string horsename, string trackName, string dateRan, string timeran, float si, string distance)
            {
                this.SaveRunAsync(guid, horsename, trackName, dateRan, timeran, si, distance, null);
            }

            public void SaveRunAsync(string guid, string horsename, string trackName, string dateRan, string timeran, float si, string distance, object userState)
            {
                if ((this.SaveRunOperationCompleted == null))
                {
                    this.SaveRunOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaveRunCompleted);
                }
                this.InvokeAsync("SaveRun", new object[] {
                        guid,
                        horsename,
                        trackName,
                        dateRan,
                        timeran,
                        si,
                        distance}, this.SaveRunOperationCompleted, userState);
            }

            private void OnSaveRunCompleted(object arg)
            {
                if ((this.SaveRunCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.SaveRunCompleted(this, new SaveRunCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetSI", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public SpeedIndex[] GetSI(string FieldName, float timeRan, string trackName)
            {
                object[] results = this.Invoke("GetSI", new object[] {
                        FieldName,
                        timeRan,
                        trackName});
                return ((SpeedIndex[])(results[0]));
            }

            public System.IAsyncResult BeginGetSI(string FieldName, float timeRan, string trackName, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetSI", new object[] {
                        FieldName,
                        timeRan,
                        trackName}, callback, asyncState);
            }

            public SpeedIndex[] EndGetSI(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((SpeedIndex[])(results[0]));
            }

            public void GetSIAsync(string FieldName, float timeRan, string trackName)
            {
                this.GetSIAsync(FieldName, timeRan, trackName, null);
            }

            public void GetSIAsync(string FieldName, float timeRan, string trackName, object userState)
            {
                if ((this.GetSIOperationCompleted == null))
                {
                    this.GetSIOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSICompleted);
                }
                this.InvokeAsync("GetSI", new object[] {
                        FieldName,
                        timeRan,
                        trackName}, this.GetSIOperationCompleted, userState);
            }

            private void OnGetSICompleted(object arg)
            {
                if ((this.GetSICompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetSICompleted(this, new GetSICompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetPropDesc", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string GetPropDesc(string OnlineID)
            {
                object[] results = this.Invoke("GetPropDesc", new object[] {
                        OnlineID});
                return ((string)(results[0]));
            }

            public System.IAsyncResult BeginGetPropDesc(string OnlineID, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetPropDesc", new object[] {
                        OnlineID}, callback, asyncState);
            }

            public string EndGetPropDesc(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string)(results[0]));
            }

            public void GetPropDescAsync(string OnlineID)
            {
                this.GetPropDescAsync(OnlineID, null);
            }

            public void GetPropDescAsync(string OnlineID, object userState)
            {
                if ((this.GetPropDescOperationCompleted == null))
                {
                    this.GetPropDescOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPropDescCompleted);
                }
                this.InvokeAsync("GetPropDesc", new object[] {
                        OnlineID}, this.GetPropDescOperationCompleted, userState);
            }

            private void OnGetPropDescCompleted(object arg)
            {
                if ((this.GetPropDescCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetPropDescCompleted(this, new GetPropDescCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetViews", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string GetViews(string OnlineID)
            {
                object[] results = this.Invoke("GetViews", new object[] {
                        OnlineID});
                return ((string)(results[0]));
            }

            public System.IAsyncResult BeginGetViews(string OnlineID, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetViews", new object[] {
                        OnlineID}, callback, asyncState);
            }

            public string EndGetViews(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string)(results[0]));
            }

            public void GetViewsAsync(string OnlineID)
            {
                this.GetViewsAsync(OnlineID, null);
            }

            public void GetViewsAsync(string OnlineID, object userState)
            {
                if ((this.GetViewsOperationCompleted == null))
                {
                    this.GetViewsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetViewsCompleted);
                }
                this.InvokeAsync("GetViews", new object[] {
                        OnlineID}, this.GetViewsOperationCompleted, userState);
            }

            private void OnGetViewsCompleted(object arg)
            {
                if ((this.GetViewsCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetViewsCompleted(this, new GetViewsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetAdditionHomeCount", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public int GetAdditionHomeCount(string addition)
            {
                object[] results = this.Invoke("GetAdditionHomeCount", new object[] {
                        addition});
                return ((int)(results[0]));
            }

            public System.IAsyncResult BeginGetAdditionHomeCount(string addition, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetAdditionHomeCount", new object[] {
                        addition}, callback, asyncState);
            }

            public int EndGetAdditionHomeCount(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((int)(results[0]));
            }

            public void GetAdditionHomeCountAsync(string addition)
            {
                this.GetAdditionHomeCountAsync(addition, null);
            }

            public void GetAdditionHomeCountAsync(string addition, object userState)
            {
                if ((this.GetAdditionHomeCountOperationCompleted == null))
                {
                    this.GetAdditionHomeCountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAdditionHomeCountCompleted);
                }
                this.InvokeAsync("GetAdditionHomeCount", new object[] {
                        addition}, this.GetAdditionHomeCountOperationCompleted, userState);
            }

            private void OnGetAdditionHomeCountCompleted(object arg)
            {
                if ((this.GetAdditionHomeCountCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetAdditionHomeCountCompleted(this, new GetAdditionHomeCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/AddActivity", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public void AddActivity(string OnlineID, string Activity, string Comments)
            {
                this.Invoke("AddActivity", new object[] {
                        OnlineID,
                        Activity,
                        Comments});
            }

            public System.IAsyncResult BeginAddActivity(string OnlineID, string Activity, string Comments, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("AddActivity", new object[] {
                        OnlineID,
                        Activity,
                        Comments}, callback, asyncState);
            }

            public void EndAddActivity(System.IAsyncResult asyncResult)
            {
                this.EndInvoke(asyncResult);
            }

            public void AddActivityAsync(string OnlineID, string Activity, string Comments)
            {
                this.AddActivityAsync(OnlineID, Activity, Comments, null);
            }

            public void AddActivityAsync(string OnlineID, string Activity, string Comments, object userState)
            {
                if ((this.AddActivityOperationCompleted == null))
                {
                    this.AddActivityOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddActivityCompleted);
                }
                this.InvokeAsync("AddActivity", new object[] {
                        OnlineID,
                        Activity,
                        Comments}, this.AddActivityOperationCompleted, userState);
            }

            private void OnAddActivityCompleted(object arg)
            {
                if ((this.AddActivityCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.AddActivityCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetRating", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public decimal GetRating(string OnlineID)
            {
                object[] results = this.Invoke("GetRating", new object[] {
                        OnlineID});
                return ((decimal)(results[0]));
            }

            public System.IAsyncResult BeginGetRating(string OnlineID, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetRating", new object[] {
                        OnlineID}, callback, asyncState);
            }

            public decimal EndGetRating(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((decimal)(results[0]));
            }

            public void GetRatingAsync(string OnlineID)
            {
                this.GetRatingAsync(OnlineID, null);
            }

            public void GetRatingAsync(string OnlineID, object userState)
            {
                if ((this.GetRatingOperationCompleted == null))
                {
                    this.GetRatingOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRatingCompleted);
                }
                this.InvokeAsync("GetRating", new object[] {
                        OnlineID}, this.GetRatingOperationCompleted, userState);
            }

            private void OnGetRatingCompleted(object arg)
            {
                if ((this.GetRatingCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetRatingCompleted(this, new GetRatingCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/getSavedRuns", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public SavedRunsList[] getSavedRuns(string guid, int sort)
            {
                object[] results = this.Invoke("getSavedRuns", new object[] {
                        guid,
                        sort});
                return ((SavedRunsList[])(results[0]));
            }

            public System.IAsyncResult BegingetSavedRuns(string guid, int sort, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("getSavedRuns", new object[] {
                        guid,
                        sort}, callback, asyncState);
            }

            public SavedRunsList[] EndgetSavedRuns(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((SavedRunsList[])(results[0]));
            }

            public void getSavedRunsAsync(string guid, int sort)
            {
                this.getSavedRunsAsync(guid, sort, null);
            }

            public void getSavedRunsAsync(string guid, int sort, object userState)
            {
                if ((this.getSavedRunsOperationCompleted == null))
                {
                    this.getSavedRunsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetSavedRunsCompleted);
                }
                this.InvokeAsync("getSavedRuns", new object[] {
                        guid,
                        sort}, this.getSavedRunsOperationCompleted, userState);
            }

            private void OngetSavedRunsCompleted(object arg)
            {
                if ((this.getSavedRunsCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.getSavedRunsCompleted(this, new getSavedRunsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/SaveRating", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public void SaveRating(string OnlineID, decimal Rating)
            {
                this.Invoke("SaveRating", new object[] {
                        OnlineID,
                        Rating});
            }

            public System.IAsyncResult BeginSaveRating(string OnlineID, decimal Rating, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("SaveRating", new object[] {
                        OnlineID,
                        Rating}, callback, asyncState);
            }

            public void EndSaveRating(System.IAsyncResult asyncResult)
            {
                this.EndInvoke(asyncResult);
            }

            public void SaveRatingAsync(string OnlineID, decimal Rating)
            {
                this.SaveRatingAsync(OnlineID, Rating, null);
            }

            public void SaveRatingAsync(string OnlineID, decimal Rating, object userState)
            {
                if ((this.SaveRatingOperationCompleted == null))
                {
                    this.SaveRatingOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaveRatingCompleted);
                }
                this.InvokeAsync("SaveRating", new object[] {
                        OnlineID,
                        Rating}, this.SaveRatingOperationCompleted, userState);
            }

            private void OnSaveRatingCompleted(object arg)
            {
                if ((this.SaveRatingCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.SaveRatingCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }

            [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ret.bz/GetAdditionalImages", RequestNamespace = "http://www.ret.bz/", ResponseNamespace = "http://www.ret.bz/", ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use = System.Web.Services.Description.SoapBindingUse.Literal)]
            public string[] GetAdditionalImages(string OnlineID)
            {
                object[] results = this.Invoke("GetAdditionalImages", new object[] {
                        OnlineID});
                return ((string[])(results[0]));
            }

            public System.IAsyncResult BeginGetAdditionalImages(string OnlineID, System.AsyncCallback callback, object asyncState)
            {
                return this.BeginInvoke("GetAdditionalImages", new object[] {
                        OnlineID}, callback, asyncState);
            }

            public string[] EndGetAdditionalImages(System.IAsyncResult asyncResult)
            {
                object[] results = this.EndInvoke(asyncResult);
                return ((string[])(results[0]));
            }

            public void GetAdditionalImagesAsync(string OnlineID)
            {
                this.GetAdditionalImagesAsync(OnlineID, null);
            }

            public void GetAdditionalImagesAsync(string OnlineID, object userState)
            {
                if ((this.GetAdditionalImagesOperationCompleted == null))
                {
                    this.GetAdditionalImagesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAdditionalImagesCompleted);
                }
                this.InvokeAsync("GetAdditionalImages", new object[] {
                        OnlineID}, this.GetAdditionalImagesOperationCompleted, userState);
            }

            private void OnGetAdditionalImagesCompleted(object arg)
            {
                if ((this.GetAdditionalImagesCompleted != null))
                {
                    System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                    this.GetAdditionalImagesCompleted(this, new GetAdditionalImagesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class ProfileStuff
        {
            public string RegistrationID;
            public string SponsorshipID;
            public string SponsImage;
            public string SponsID;
            public string Description;
            public string link;
            public string FirstName;
            public string LastName;
            public string Company;
            public string Address1;
            public string Address2;
            public string City;
            public string State;
            public string Zip;
            public string Phone;
            public string Mobile;
            public string Email;
            public string Username;
            public string Password;
            public string ID;
            public string IsJockey;
            public string IsTrainer;
            public string IsOwner;
            public string IsBreeder;
            public string IsSponsor;
            public string IsUser;
            public string Headline;
            public string HeadlineSubCopy;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class ListingPreview
        {
            public string Company;
            public string area;
            public string Address;
            public string City;
            public string Addition;
            public string Latitude;
            public string Longitude;
            public string id;
            public string email;
            public string AdditionalImages;
            public string price;
            public string sf;
            public string tb;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class Listings
        {
            public string Builder;
            public string Company;
            public string Address;
            public string City;
            public string Area;
            public string Addition;
            public string Phone;
            public string Latitude;
            public string Longitude;
            public string Resolution;
            public string Status;
            public string PropID;
            public string GarageShow;
            public string GarageDet;
            public string AddressFromGuide;
            public string Text;
            public string ImageName;
            public string IsElite;
            public string IsProtected;
            public string IsSponsor;
            public string ReCapture;
            public string PropNotes;
            public string CustomMap;
            public string newfield;
            public string UserNotes;
            public string HasUpdates;
            public string Price;
            public string Baths;
            public string Beds;
            public string Warranty;
            public string HouseType;
            public string Plans;
            public string AdditionalImages;
            public string BuilderEmail;
            public string BuilderAdditionalInfo;
            public string UpdateDate;
            public string HouseInfoUpdated;
            public string MapPopUpDesc_WO;
            public string TotalRates_WO;
            public string RatingAverage_WO;
            public string FiveRates_WO;
            public string FourRates_WO;
            public string ThreeRates_WO;
            public string TwoRates_WO;
            public string OneRates_WO;
            public string POHID;
            public string directions;
            public string ammen;
            public string associates;
            public string facebook;
            public string twitter;
            public string sf;
            public string id;
            public string OpenDate;
            public string OpenHours;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class FeatureInfo
        {
            public string FirstName;
            public string LastName;
            public string Company;
            public string id;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class RaceInfoFull
        {
            public string RACETRACK;
            public string RACENAME;
            public string GRADE;
            public string DATE;
            public string OKBRED;
            public string SEX;
            public string AGE;
            public string BREED;
            public string DISTANCE;
            public string ESTIMATED;
            public string ADD_GUARANTEE;
            public string NOM_CLOSINGDATE;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class RaceEntries
        {
            public string maxclaim;
            public string final;
            public string distance;
            public string name;
            public string dayEvening;
            public string raceDescription;
            public string number;
            public Starter[] starters;
            public string post;
            public string purse;
            public string surface;
            public string minclaim;
            public RaceDate date;
            public string purseEnhancements;
            public string type;
            public string track;
            public string PostConvert;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class Starter
        {
            public Horses Horse;
            public string ProgramNumber;
            public Trainers Trainer;
            public Jockeys Jockey;
            public string postPosition;
            public string morningLineOdd;
            public string scratchIndicator;
            public Owners Owner;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class Horses
        {
            public string registry;
            public string name;
            public string sex;
            public string referenceNumber;
            public string foalingDate;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class Trainers
        {
            public string middleName;
            public string firstName;
            public string identity;
            public string type;
            public string lastName;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class Jockeys
        {
            public string middleName;
            public string firstName;
            public string identity;
            public string type;
            public string lastName;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class Owners
        {
            public string middleName;
            public string firstName;
            public string lastName;
            public string identity;
            public string type;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class RaceDate
        {
            public string day;
            public string month;
            public string year;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class UpcomingRaces
        {
            public string PostTime;
            public string RaceCount;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class Sponsors
        {
            public string RegistrationID;
            public string SponsorshipID;
            public string ProfileSubjectID;
            public string IsProfile;
            public string IsHorse;
            public string Headline;
            public string HeadlineSubCopy;
            public string Description;
            public string Image;
            public string link;
            public string Address1;
            public string Address2;
            public string City;
            public string State;
            public string Zip;
            public string Phone;
            public string Mobile;
            public string Email;
            public string ID;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class SponsorsList
        {
            public string Headline;
            public string ID;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class AlexClass
        {
            public string Kids;
            public string Dog;
            public string Mom;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class Races
        {
            public string maxclaim;
            public string post;
            public string surface;
            public string distance;
            public string purse;
            public string name;
            public string dayEvening;
            public RaceDate date;
            public string type;
            public string number;
            public string PostConvert;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class RaceResults
        {
            public string distance;
            public string name;
            public string grade;
            public Exotic[] exoticPayoffs;
            public string dayEvening;
            public string number;
            public ResultStarters[] starters;
            public string purse;
            public string surface;
            public string nonbetting;
            public RaceDate date;
            public string type;
            public string track;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class Exotic
        {
            public string name;
            public string winningNumbers;
            public string wagerAmount;
            public string numberOfRights;
            public string type;
            public string payoffAmount;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class ResultStarters
        {
            public string mutuelPosition;
            public string officialPosition;
            public string programNumber;
            public string winPayoff;
            public string postPosition;
            public string finishPosition;
            public string odds;
            public string placePayoff;
            public string scratchIndicator;
            public string showPayoff;
            public string disqualified;
            public Trainers Trainer;
            public Jockeys Jockey;
            public Horses Horse;
            public Owners Owner;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class RacesResults
        {
            public string post;
            public string surface;
            public string distance;
            public string purse;
            public string name;
            public string dayEvening;
            public RaceDate date;
            public string type;
            public string number;
            public string PostConvert;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class Track
        {
            public string TrackName;
            public string Content;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class StakesInfo
        {
            public string id;
            public string Racetrack;
            public string Racename;
            public string GRADE;
            public string DATE;
            public string OK_BRED;
            public string SEX;
            public string AGE;
            public string BREED;
            public string DISTANCE;
            public string ESTIMATED_PURSE;
            public string ADD_GUARANTEE;
            public string NOM_CLOSINGDATE;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class EventsList
        {
            public System.DateTime EventDate;
            public string EventDesc;
            public string EventClass;
            public string EventID;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class VideoDates
        {
            public string raceDate;
            public string raceTrack;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class Videos
        {
            public string id;
            public string raceDate;
            public string race;
            public string raceid;
            public string mobilefilename;
            public string flashmobilefilename;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class eStallionMember
        {
            public string HorseName;
            public string esId;
            public string hType;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class SpeedIndex
        {
            public string SI;
            public string Track;
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ret.bz/")]
        public partial class SavedRunsList
        {
            public string HorseName;
            public string Track;
            public float RunTime;
            public string DateRan;
            public int Distance;
            public string SpeedIndex;
        }

        public partial class GetProfileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetProfileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public ProfileStuff Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((ProfileStuff)(this.results[0]));
                }
            }
        }

        public delegate void GetProfileCompletedEventHandler(object sender, GetProfileCompletedEventArgs args);

        public partial class GeneratePOHUnResCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GeneratePOHUnResCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public ListingPreview[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((ListingPreview[])(this.results[0]));
                }
            }
        }

        public delegate void GeneratePOHUnResCompletedEventHandler(object sender, GeneratePOHUnResCompletedEventArgs args);

        public delegate void UpdatePOHGPSCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs args);

        public partial class GetPOHAdditionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHAdditionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHAdditionsCompletedEventHandler(object sender, GetPOHAdditionsCompletedEventArgs args);

        public partial class GetPOHListingByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHListingByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public Listings Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((Listings)(this.results[0]));
                }
            }
        }

        public delegate void GetPOHListingByIdCompletedEventHandler(object sender, GetPOHListingByIdCompletedEventArgs args);

        public partial class GetImagesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetImagesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string)(this.results[0]));
                }
            }
        }

        public delegate void GetImagesCompletedEventHandler(object sender, GetImagesCompletedEventArgs args);

        public partial class GetPOHListingById_POHIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHListingById_POHIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public Listings Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((Listings)(this.results[0]));
                }
            }
        }

        public delegate void GetPOHListingById_POHIDCompletedEventHandler(object sender, GetPOHListingById_POHIDCompletedEventArgs args);

        public partial class GetBookmarksPOHCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetBookmarksPOHCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public ListingPreview[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((ListingPreview[])(this.results[0]));
                }
            }
        }

        public delegate void GetBookmarksPOHCompletedEventHandler(object sender, GetBookmarksPOHCompletedEventArgs args);

        public partial class GetPOHAllPreviewCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHAllPreviewCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public ListingPreview[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((ListingPreview[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHAllPreviewCompletedEventHandler(object sender, GetPOHAllPreviewCompletedEventArgs args);

        public partial class GetPOHAllPreviewRECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHAllPreviewRECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public ListingPreview[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((ListingPreview[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHAllPreviewRECompletedEventHandler(object sender, GetPOHAllPreviewRECompletedEventArgs args);

        public delegate void GetEStallionsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs args);

        public partial class GetPOHAllPreviewSearchCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHAllPreviewSearchCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public ListingPreview[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((ListingPreview[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHAllPreviewSearchCompletedEventHandler(object sender, GetPOHAllPreviewSearchCompletedEventArgs args);

        public partial class GetPOHAllPreviewSearchRECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHAllPreviewSearchRECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public ListingPreview[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((ListingPreview[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHAllPreviewSearchRECompletedEventHandler(object sender, GetPOHAllPreviewSearchRECompletedEventArgs args);

        public partial class GetPOHAllPreviewSearchREWebCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHAllPreviewSearchREWebCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public ListingPreview[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((ListingPreview[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHAllPreviewSearchREWebCompletedEventHandler(object sender, GetPOHAllPreviewSearchREWebCompletedEventArgs args);

        public partial class GetPOHAllPreviewBetaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHAllPreviewBetaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public ListingPreview[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((ListingPreview[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHAllPreviewBetaCompletedEventHandler(object sender, GetPOHAllPreviewBetaCompletedEventArgs args);

        public partial class GetPOHGeoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHGeoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public ListingPreview[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((ListingPreview[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHGeoCompletedEventHandler(object sender, GetPOHGeoCompletedEventArgs args);

        public partial class GetPOHCitiesByAreaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHCitiesByAreaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHCitiesByAreaCompletedEventHandler(object sender, GetPOHCitiesByAreaCompletedEventArgs args);

        public partial class GetPOHCitiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHCitiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHCitiesCompletedEventHandler(object sender, GetPOHCitiesCompletedEventArgs args);

        public partial class GetPOHOpenDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHOpenDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHOpenDateCompletedEventHandler(object sender, GetPOHOpenDateCompletedEventArgs args);

        public partial class GetPOHCompanyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHCompanyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHCompanyCompletedEventHandler(object sender, GetPOHCompanyCompletedEventArgs args);

        public partial class GetPOHBuildersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHBuildersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHBuildersCompletedEventHandler(object sender, GetPOHBuildersCompletedEventArgs args);

        public partial class GetPOHListingsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHListingsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public Listings[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((Listings[])(this.results[0]));
                }
            }
        }

        public delegate void GetPOHListingsCompletedEventHandler(object sender, GetPOHListingsCompletedEventArgs args);

        public partial class GetTipSheetsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetTipSheetsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string)(this.results[0]));
                }
            }
        }

        public delegate void GetTipSheetsCompletedEventHandler(object sender, GetTipSheetsCompletedEventArgs args);

        public partial class GetOvernightsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetOvernightsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string)(this.results[0]));
                }
            }
        }

        public delegate void GetOvernightsCompletedEventHandler(object sender, GetOvernightsCompletedEventArgs args);

        public partial class GetSpIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetSpIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string)(this.results[0]));
                }
            }
        }

        public delegate void GetSpIDCompletedEventHandler(object sender, GetSpIDCompletedEventArgs args);

        public partial class GetFeaturedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetFeaturedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public FeatureInfo[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((FeatureInfo[])(this.results[0]));
                }
            }
        }

        public delegate void GetFeaturedCompletedEventHandler(object sender, GetFeaturedCompletedEventArgs args);

        public partial class GetFeaturedNewCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetFeaturedNewCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public FeatureInfo[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((FeatureInfo[])(this.results[0]));
                }
            }
        }

        public delegate void GetFeaturedNewCompletedEventHandler(object sender, GetFeaturedNewCompletedEventArgs args);

        public partial class GetStoryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetStoryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string)(this.results[0]));
                }
            }
        }

        public delegate void GetStoryCompletedEventHandler(object sender, GetStoryCompletedEventArgs args);

        public partial class GetCallByDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetCallByDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public RaceInfoFull[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((RaceInfoFull[])(this.results[0]));
                }
            }
        }

        public delegate void GetCallByDateCompletedEventHandler(object sender, GetCallByDateCompletedEventArgs args);

        public partial class GetRaceDatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetRaceDatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string)(this.results[0]));
                }
            }
        }

        public delegate void GetRaceDatesCompletedEventHandler(object sender, GetRaceDatesCompletedEventArgs args);

        public partial class GetVidsByDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetVidsByDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public RaceInfoFull[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((RaceInfoFull[])(this.results[0]));
                }
            }
        }

        public delegate void GetVidsByDateCompletedEventHandler(object sender, GetVidsByDateCompletedEventArgs args);

        public partial class GetRaceEntriesFromEQCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetRaceEntriesFromEQCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public RaceEntries[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((RaceEntries[])(this.results[0]));
                }
            }
        }

        public delegate void GetRaceEntriesFromEQCompletedEventHandler(object sender, GetRaceEntriesFromEQCompletedEventArgs args);

        public partial class GetUpcomingRacesListBUCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetUpcomingRacesListBUCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public UpcomingRaces[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((UpcomingRaces[])(this.results[0]));
                }
            }
        }

        public delegate void GetUpcomingRacesListBUCompletedEventHandler(object sender, GetUpcomingRacesListBUCompletedEventArgs args);

        public partial class GetHRSponsorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetHRSponsorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public Sponsors Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((Sponsors)(this.results[0]));
                }
            }
        }

        public delegate void GetHRSponsorCompletedEventHandler(object sender, GetHRSponsorCompletedEventArgs args);

        public partial class GetHRSponsorListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetHRSponsorListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public SponsorsList[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((SponsorsList[])(this.results[0]));
                }
            }
        }

        public delegate void GetHRSponsorListCompletedEventHandler(object sender, GetHRSponsorListCompletedEventArgs args);

        public partial class GetUpcomingRacesListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetUpcomingRacesListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public UpcomingRaces[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((UpcomingRaces[])(this.results[0]));
                }
            }
        }

        public delegate void GetUpcomingRacesListCompletedEventHandler(object sender, GetUpcomingRacesListCompletedEventArgs args);

        public partial class GetUpcomingRacesListDBCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetUpcomingRacesListDBCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public UpcomingRaces[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((UpcomingRaces[])(this.results[0]));
                }
            }
        }

        public delegate void GetUpcomingRacesListDBCompletedEventHandler(object sender, GetUpcomingRacesListDBCompletedEventArgs args);

        public partial class GetResultsListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetResultsListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public UpcomingRaces[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((UpcomingRaces[])(this.results[0]));
                }
            }
        }

        public delegate void GetResultsListCompletedEventHandler(object sender, GetResultsListCompletedEventArgs args);

        public partial class GetResultsListV2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetResultsListV2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public UpcomingRaces[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((UpcomingRaces[])(this.results[0]));
                }
            }
        }

        public delegate void GetResultsListV2CompletedEventHandler(object sender, GetResultsListV2CompletedEventArgs args);

        public partial class GetResultsListNewCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetResultsListNewCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public UpcomingRaces[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((UpcomingRaces[])(this.results[0]));
                }
            }
        }

        public delegate void GetResultsListNewCompletedEventHandler(object sender, GetResultsListNewCompletedEventArgs args);

        public partial class AlexTestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal AlexTestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public AlexClass Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((AlexClass)(this.results[0]));
                }
            }
        }

        public delegate void AlexTestCompletedEventHandler(object sender, AlexTestCompletedEventArgs args);

        public partial class GetResultsListDBCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetResultsListDBCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public UpcomingRaces[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((UpcomingRaces[])(this.results[0]));
                }
            }
        }

        public delegate void GetResultsListDBCompletedEventHandler(object sender, GetResultsListDBCompletedEventArgs args);

        public partial class GetRacesFromEQCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetRacesFromEQCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public Races[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((Races[])(this.results[0]));
                }
            }
        }

        public delegate void GetRacesFromEQCompletedEventHandler(object sender, GetRacesFromEQCompletedEventArgs args);

        public partial class GetRaceResultsEntriesFromEQCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetRaceResultsEntriesFromEQCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public RaceResults[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((RaceResults[])(this.results[0]));
                }
            }
        }

        public delegate void GetRaceResultsEntriesFromEQCompletedEventHandler(object sender, GetRaceResultsEntriesFromEQCompletedEventArgs args);

        public partial class GetRacesResultsFromEQCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetRacesResultsFromEQCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public RacesResults[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((RacesResults[])(this.results[0]));
                }
            }
        }

        public delegate void GetRacesResultsFromEQCompletedEventHandler(object sender, GetRacesResultsFromEQCompletedEventArgs args);

        public partial class GetStakeDatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetStakeDatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string)(this.results[0]));
                }
            }
        }

        public delegate void GetStakeDatesCompletedEventHandler(object sender, GetStakeDatesCompletedEventArgs args);

        public partial class GetTrackCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetTrackCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public Track Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((Track)(this.results[0]));
                }
            }
        }

        public delegate void GetTrackCompletedEventHandler(object sender, GetTrackCompletedEventArgs args);

        public partial class GetStakesInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetStakesInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public StakesInfo[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((StakesInfo[])(this.results[0]));
                }
            }
        }

        public delegate void GetStakesInfoCompletedEventHandler(object sender, GetStakesInfoCompletedEventArgs args);

        public partial class GetRaceInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetRaceInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetRaceInfoCompletedEventHandler(object sender, GetRaceInfoCompletedEventArgs args);

        public partial class GetAllEventsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetAllEventsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetAllEventsCompletedEventHandler(object sender, GetAllEventsCompletedEventArgs args);

        public partial class GetAllEventsWACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetAllEventsWACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public EventsList[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((EventsList[])(this.results[0]));
                }
            }
        }

        public delegate void GetAllEventsWACompletedEventHandler(object sender, GetAllEventsWACompletedEventArgs args);

        public partial class GetRaceEventsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetRaceEventsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetRaceEventsCompletedEventHandler(object sender, GetRaceEventsCompletedEventArgs args);

        public partial class GetVideosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetVideosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetVideosCompletedEventHandler(object sender, GetVideosCompletedEventArgs args);

        public partial class GetContactCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetContactCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string)(this.results[0]));
                }
            }
        }

        public delegate void GetContactCompletedEventHandler(object sender, GetContactCompletedEventArgs args);

        public partial class GetVideosListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetVideosListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public VideoDates[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((VideoDates[])(this.results[0]));
                }
            }
        }

        public delegate void GetVideosListCompletedEventHandler(object sender, GetVideosListCompletedEventArgs args);

        public partial class GetVideosListNewCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetVideosListNewCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public VideoDates[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((VideoDates[])(this.results[0]));
                }
            }
        }

        public delegate void GetVideosListNewCompletedEventHandler(object sender, GetVideosListNewCompletedEventArgs args);

        public partial class GetVideosWACompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetVideosWACompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public Videos[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((Videos[])(this.results[0]));
                }
            }
        }

        public delegate void GetVideosWACompletedEventHandler(object sender, GetVideosWACompletedEventArgs args);

        public partial class GetCalEventsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetCalEventsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetCalEventsCompletedEventHandler(object sender, GetCalEventsCompletedEventArgs args);

        public partial class GetAdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetAdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string)(this.results[0]));
                }
            }
        }

        public delegate void GetAdCompletedEventHandler(object sender, GetAdCompletedEventArgs args);

        public partial class GetPOHAdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPOHAdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string)(this.results[0]));
                }
            }
        }

        public delegate void GetPOHAdCompletedEventHandler(object sender, GetPOHAdCompletedEventArgs args);

        public partial class GetAdLocationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetAdLocationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string)(this.results[0]));
                }
            }
        }

        public delegate void GetAdLocationCompletedEventHandler(object sender, GetAdLocationCompletedEventArgs args);

        public delegate void ClickedAdCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs args);

        public partial class GetChangedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetChangedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetChangedCompletedEventHandler(object sender, GetChangedCompletedEventArgs args);

        public partial class GetStallionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetStallionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public eStallionMember[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((eStallionMember[])(this.results[0]));
                }
            }
        }

        public delegate void GetStallionsCompletedEventHandler(object sender, GetStallionsCompletedEventArgs args);

        public partial class GetHorsesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetHorsesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public eStallionMember[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((eStallionMember[])(this.results[0]));
                }
            }
        }

        public delegate void GetHorsesCompletedEventHandler(object sender, GetHorsesCompletedEventArgs args);

        public partial class GetChangedMySqlRealCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetChangedMySqlRealCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetChangedMySqlRealCompletedEventHandler(object sender, GetChangedMySqlRealCompletedEventArgs args);

        public partial class GetChangedMySqlReal2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetChangedMySqlReal2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetChangedMySqlReal2CompletedEventHandler(object sender, GetChangedMySqlReal2CompletedEventArgs args);

        public partial class GetChangedMySqlCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetChangedMySqlCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetChangedMySqlCompletedEventHandler(object sender, GetChangedMySqlCompletedEventArgs args);

        public partial class SavePOHBookmarkCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal SavePOHBookmarkCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public bool Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((bool)(this.results[0]));
                }
            }
        }

        public delegate void SavePOHBookmarkCompletedEventHandler(object sender, SavePOHBookmarkCompletedEventArgs args);

        public partial class SaveRunCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal SaveRunCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public bool Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((bool)(this.results[0]));
                }
            }
        }

        public delegate void SaveRunCompletedEventHandler(object sender, SaveRunCompletedEventArgs args);

        public partial class GetSICompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetSICompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public SpeedIndex[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((SpeedIndex[])(this.results[0]));
                }
            }
        }

        public delegate void GetSICompletedEventHandler(object sender, GetSICompletedEventArgs args);

        public partial class GetPropDescCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetPropDescCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string)(this.results[0]));
                }
            }
        }

        public delegate void GetPropDescCompletedEventHandler(object sender, GetPropDescCompletedEventArgs args);

        public partial class GetViewsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetViewsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string)(this.results[0]));
                }
            }
        }

        public delegate void GetViewsCompletedEventHandler(object sender, GetViewsCompletedEventArgs args);

        public partial class GetAdditionHomeCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetAdditionHomeCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public int Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((int)(this.results[0]));
                }
            }
        }

        public delegate void GetAdditionHomeCountCompletedEventHandler(object sender, GetAdditionHomeCountCompletedEventArgs args);

        public delegate void AddActivityCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs args);

        public partial class GetRatingCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetRatingCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public decimal Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((decimal)(this.results[0]));
                }
            }
        }

        public delegate void GetRatingCompletedEventHandler(object sender, GetRatingCompletedEventArgs args);

        public partial class getSavedRunsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal getSavedRunsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public SavedRunsList[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((SavedRunsList[])(this.results[0]));
                }
            }
        }

        public delegate void getSavedRunsCompletedEventHandler(object sender, getSavedRunsCompletedEventArgs args);

        public delegate void SaveRatingCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs args);

        public partial class GetAdditionalImagesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            private object[] results;

            internal GetAdditionalImagesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
            {
                this.results = results;
            }

            public string[] Result
            {
                get
                {
                    this.RaiseExceptionIfNecessary();
                    return ((string[])(this.results[0]));
                }
            }
        }

        public delegate void GetAdditionalImagesCompletedEventHandler(object sender, GetAdditionalImagesCompletedEventArgs args);
    }
}