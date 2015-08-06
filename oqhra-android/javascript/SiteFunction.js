var currentTrack;
// ************************************************************************
//  Our Functions
// ************************************************************************

function enableVideoClicks() {
    var videos = document.getElementsByTagName('video') || [];
    for (var i = 0; i < videos.length; i++) {
        // TODO: use attachEvent in IE
        videos[i].addEventListener('click', function (videoNode) {
            return function () {
                videoNode.play();
            };
        } (videos[i]));
    }
};
function downloadAlert(downloadItem) {
    alert("The " + downloadItem + " is currently downloading to your phone as a pdf file.  Please be patient. The file can be found where your phone stores your downloads.");
};

// ************************************************************************
//  Navigation Functions
// ************************************************************************
function nav(newPage, currentPage, sponsor) {
    //alert("NewPage: " + newPage + "  CurrentPage: " + currentPage);
    document.getElementById(newPage).style.display = "block";
    document.getElementById(currentPage).style.display = "none";
    if (newPage == "HomeContainer1" || newPage == "StakesContainer1" || newPage == "CalendarContainer" || newPage == "NewsContainer") {
        btmMenuTap(newPage);
    }
    else {
        resetBtmMenu();
    }
    switchSponsor(sponsor);
    refreshScrolls();
};
function btmNav(newPage, sponsor) {
    btmMenuTap(newPage);
    //Determine which child of "Content" is block, which would be the current page
    var myDivList = document.getElementById('Content');
    for (i = 0; i < myDivList.childNodes.length; i++) {
        if (myDivList.childNodes[i].nodeName == "DIV" && myDivList.childNodes[i].style.display == "block") {
            myDivList.childNodes[i].style.display = "none";
            break;
        }
    }
    document.getElementById(newPage).style.display = "block";
    switchSponsor(sponsor);
    refreshScrolls();
};
function btmMenuTap(newPage) {
    var myIcon = "";
    var myButton = "";
    var myText = "";
    var myBack = "";

    resetBtmMenu();
    if (newPage == "HomeContainer1") {
        myIcon = "images/Components/Icon-Home-Over.png";
        myButton = "ImageButton1";
        myText = "Text1";
        myBack = "BtmMenuItem1";
    }
    if (newPage == "StakesContainer1") {
        myIcon = "images/Components/Icon-Stakes-Over.png";
        myButton = "ImageButton2";
        myText = "Text2";
        myBack = "BtmMenuItem2";
    }
    if (newPage == "CalendarContainer1") {
        myIcon = "images/Components/Icon-Calendar-Over.png";
        myButton = "ImageButton3";
        myText = "Text3";
        myBack = "BtmMenuItem3";
    }
    if (newPage == "NewsContainer1") {
        myIcon = "images/Components/Icon-News-Over.png";
        myButton = "ImageButton4";
        myText = "Text4";
        myBack = "BtmMenuItem4";
    }
    document.getElementById(myButton).src = myIcon;
    document.getElementById(myText).style.color = "White";
    document.getElementById(myBack).style.background = "url(images/iPhone/Retina/BtmMenu-BackOverlay.png) no-repeat fixed center center";
    document.getElementById(myBack).style.backgroundSize = "cover";
};
function resetBtmMenu() {
    //Reset all Bottom Menu Button Images
    document.getElementById('ImageButton1').src = "images/Components/Icon-Home.png";
    document.getElementById('ImageButton2').src = "images/Components/Icon-Stakes.png";
    document.getElementById('ImageButton3').src = "images/Components/Icon-Calendar.png";
    document.getElementById('ImageButton4').src = "images/Components/Icon-News.png";

    //Reset all Bottom Menu Text Colors
    document.getElementById('Text1').style.color = "#c6c6c5";
    document.getElementById('Text2').style.color = "#c6c6c5";
    document.getElementById('Text3').style.color = "#c6c6c5";
    document.getElementById('Text4').style.color = "#c6c6c5";

    //Reset all the Background overlays
    document.getElementById('BtmMenuItem1').style.backgroundImage = "url(images/transparent.png)";
    document.getElementById('BtmMenuItem2').style.backgroundImage = "url(images/transparent.png)";
    document.getElementById('BtmMenuItem3').style.backgroundImage = "url(images/transparent.png)";
    document.getElementById('BtmMenuItem4').style.backgroundImage = "url(images/transparent.png)";
};
function switchSponsor(sponsor) {
    if (sponsor == "HP") {
        document.getElementById('ImageTopBanner').src = "images/ads/HP-iPhone.jpg";
        document.getElementById('topBannerLink').href = "http://www.heritageplace.com";
        document.getElementById('Content').style.backgroundImage = "url(  '../images/Back-Home.jpg' )";
    };
    if (sponsor == "racehorseplace") {
        document.getElementById('ImageTopBanner').src = "images/ads/RaceHorsePlace-iPhone.jpg";
        document.getElementById('topBannerLink').href = "http://www.racehorseplace.com";
        document.getElementById('Content').style.backgroundImage = "url(  '../images/Back-RaceHorsePlace.jpg' )";
    };
    if (sponsor == "BobMoore") {
        document.getElementById('ImageTopBanner').src = "images/ads/BobMoore-iPhone.jpg";
        document.getElementById('topBannerLink').href = "http://www.bobmoorefarms.com";
        document.getElementById('Content').style.backgroundImage = "url(  '../images/Back-BobMoore.jpg' )";
    };
    if (sponsor == "AQHA") {
        document.getElementById('ImageTopBanner').src = "images/ads/AQHA-iPhone.jpg";
        document.getElementById('topBannerLink').href = "http://www.aqha.com";
        document.getElementById('Content').style.backgroundImage = "url(  '../images/Back-AQHA.jpg' )";
    };
    if (sponsor == "Markel") {
        document.getElementById('ImageTopBanner').src = "images/ads/Markel-iPhone.jpg";
        document.getElementById('topBannerLink').href = "http://www.quarterhorseinsurance.com";
        document.getElementById('Content').style.backgroundImage = "url(  '../images/Back-Markel.jpg' )";
    };
    if (sponsor == "LazyE") {
        document.getElementById('ImageTopBanner').src = "images/ads/LazyE-iphone.jpg";
        document.getElementById('topBannerLink').href = "http://www.lazyeranch.net";
        document.getElementById('Content').style.backgroundImage = "url(  '../images/Back-LazyE.jpg' )";
    };
    if (sponsor == "Yearsley") {
        document.getElementById('ImageTopBanner').src = "images/ads/Yearsley-iPhone.jpg";
        document.getElementById('topBannerLink').href = "http://www.yearsleybloodstockgroup.com";
        document.getElementById('Content').style.backgroundImage = "url(  '../images/Back-Yearsley.jpg' )";
    };
    if (sponsor == "Track") {
        document.getElementById('ImageTopBanner').src = "images/ads/Track-iPhone.jpg";
        document.getElementById('topBannerLink').href = "http://trackmagazine.com";
        document.getElementById('Content').style.backgroundImage = "url(  '../images/Back-Track.jpg' )";
    };
    if (sponsor == "SES") {
        document.getElementById('ImageTopBanner').src = "images/ads/SES-iPhone.jpg";
        document.getElementById('topBannerLink').href = "http://www.stallionesearch.com";
        document.getElementById('Content').style.backgroundImage = "url(  '../images/Back-StallionESearch.jpg' )";
    };
    if (sponsor == "PYC") {
        document.getElementById('ImageTopBanner').src = "images/ads/PYC-iPhone.jpg";
        document.getElementById('topBannerLink').href = "";
        document.getElementById('Content').style.backgroundImage = "url(  '../images/Back-PYC.jpg' )";
    };
};
function toggleDiv(category, newDiv) {
    var main;
    var upcoming;
    var results;
    var videos;

    if (category == "rp") {
        main = "remingtonMain";
        upcoming = "remingtonUpcoming";
        results = "remingtonResults";
        videos = "remingtonVideos";
    }
    if (category == "wr") {
        main = "willrogersMain";
        upcoming = "willrogersUpcoming";
        results = "willrogersResults";
        videos = "willrogersVideos";
    }
    if (category == "fm") {
        main = "fairmeadowsMain";
        upcoming = "fairmeadowsUpcoming";
        results = "fairmeadowsResults";
        videos = "fairmeadowsVideos";
    }
    document.getElementById(main).style.display = "none";
    document.getElementById(upcoming).style.display = "none";
    document.getElementById(results).style.display = "none";
    document.getElementById(videos).style.display = "none";
    if (newDiv == main) { document.getElementById(main).style.display = "block"; }
    if (newDiv == upcoming) { document.getElementById(upcoming).style.display = "block"; }
    if (newDiv == results) { document.getElementById(results).style.display = "block"; }
    if (newDiv == videos) { document.getElementById(videos).style.display = "block"; }
};
function toggleSavedRuns(newDiv) {
    document.getElementById('siResults').style.display = "none";
    document.getElementById('SavedRunsTrack').style.display = "none";
    document.getElementById('SavedRunsTime').style.display = "none";
    document.getElementById('SavedRunsDistance').style.display = "none";
    document.getElementById('SavedRunsDate').style.display = "none";

    document.getElementById(newDiv).style.display = "block";
}
function showLoading() {
    document.getElementById('loading').style.display = "block";
};
function hideLoading() {
    document.getElementById('loading').style.display = "none";
};
function showPopup() {
    document.getElementById('popupContainer').style.display = "block";
};
function hidePopup() {
    document.getElementById('popupContainer').style.display = "none";
};
// ************************************************************************
//  END - Navigation Functions
// ************************************************************************

//******************************************************
//  Web Methods
//  ***Note: Have to refresh the scrolls after we have changed the DOM
//******************************************************
//From Individual Tracks
function ShowUpcoming(dateStr) {
    showLoading();
    PageMethods.GetRaces("RP", dateStr, MethodResultsRaces);
};
function MethodResultsRaces(ResultsString) {
    document.getElementById('remResults').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

//From Home Races
function ShowUpcomingAll(dateStr) {
    showLoading();
    PageMethods.GetRacesAll("RP", dateStr, MethodResultsRacesAll);
};
function MethodResultsRacesAll(ResultsString) {
    //alert(ResultsString);
    document.getElementById('raceResults').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function ShowUpcomingRace(dateStr) {
    showLoading();
    PageMethods.GetRace("RP", dateStr, MethodResultsGetRace);
};
function MethodResultsGetRace(ResultsString) {
    document.getElementById('remDetails').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function ShowUpcomingRaceAll(dateStr) {
    showLoading();
    PageMethods.GetRace("RP", dateStr, MethodResultsGetRaceAll);
};
function MethodResultsGetRaceAll(ResultsString) {
    document.getElementById('racesDetails').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

//From the Home Menu to display in RacesContainer1
function getUpcomingList() {
    showLoading();
    PageMethods.GetUpcomingRacesAll("RP", MethodResultsGetUpcoming);
};
function MethodResultsGetUpcoming(ResultsString) {
    document.getElementById('UpcomingRaces').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

// Called from Home & displays in ResultsContainer1
function getResultsList() {
    showLoading();
    PageMethods.GetRaceResultsListAll("RP", MethodResultsGetRaceResultList);
};
function MethodResultsGetRaceResultList(ResultsString) {
    document.getElementById('RacesResults').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function ShowResults(dateStr) {
    showLoading();
    PageMethods.GetResults("RP", dateStr, MethodShowResults);
};
function MethodShowResults(ResultsString) {
    document.getElementById('remResults').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function ShowResultsAll(dateStr) {
    showLoading();
    PageMethods.GetResultsAll("RP", dateStr, MethodShowResultsAll);
};
function MethodShowResultsAll(ResultsString) {
    document.getElementById('resultsResults').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function ShowResultsRace(dateStr) {
    showLoading();
    PageMethods.GetRaceResults("RP", dateStr, MethodResultsShowResultsRace);
};
function MethodResultsShowResultsRace(ResultsStr) {
    document.getElementById('remDetails').innerHTML = ResultsStr;
    hideLoading();
    refreshScrolls();
};

function ShowResultsRaceAll(dateStr) {
    showLoading();
    PageMethods.GetRaceResults("RP", dateStr, MethodResultsShowResultsRaceAll);
};
function MethodResultsShowResultsRaceAll(ResultsStr) {
    document.getElementById('resultsDetails').innerHTML = ResultsStr;
    hideLoading();
    refreshScrolls();
};

//Upcoming & Results From the Individual Track Screens
function rpUpcoming() {
    showLoading();
    PageMethods.GetUpcomingRaces("RP", MethodResultsGetUpcomingRP);
};
function MethodResultsGetUpcomingRP(ResultsString) {
    document.getElementById('remingtonUpcoming').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function wrUpcoming() {
    showLoading();
    PageMethods.GetUpcomingRaces("WRD", MethodResultsGetUpcomingWRD);
};
function MethodResultsGetUpcomingWRD(ResultsString) {
    ResultsString = "<div class=\"pageMenuItem\">" + "There are currently no races available." + "</div>";
    document.getElementById('willrogersUpcoming').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function fmUpcoming() {
    showLoading();
    PageMethods.GetUpcomingRaces("FMT", MethodResultsGetUpcomingFMT)
};
function MethodResultsGetUpcomingFMT(ResultsString) {
    ResultsString = "<div class=\"pageMenuItem\">" + "There are currently no races available." + "</div>";
    document.getElementById('fairmeadowsUpcoming').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function rpResults() {
    showLoading();
    PageMethods.GetRaceResultsList("RP", MethodResultsGetRaceResultListRP);
};
function MethodResultsGetRaceResultListRP(ResultsString) {
    document.getElementById('remingtonResults').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function wrResults() {
    showLoading();
    PageMethods.GetRaceResultsList("WRD", MethodResultsGetRaceResultListWRD);
};
function MethodResultsGetRaceResultListWRD(ResultsString) {
    document.getElementById('willrogersResults').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function fmResults() {
    showLoading();
    PageMethods.GetRaceResultsList("FMT", MethodResultsGetRaceResultListFMT);
};
function MethodResultsGetRaceResultListFMT(ResultsString) {
    document.getElementById('fairmeadowsResults').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

//Videos from individual track screens
function rpVideos() {
    showLoading();
    PageMethods.GetVideosList("RED", MethodResultsGetVideosListRED);
};
function MethodResultsGetVideosListRED(ResultsString) {
    document.getElementById('remingtonVideos').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function wrVideos() {
    showLoading();
    PageMethods.GetVideosList("WRD", MethodResultsGetVideosListWRD);
};
function MethodResultsGetVideosListWRD(ResultsString) {
    document.getElementById('willrogersVideos').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function fmVideos() {
    showLoading();
    PageMethods.GetVideosList("FM", MethodResultsGetVideosListFM);
};
function MethodResultsGetVideosListFM(ResultsString) {
    document.getElementById('fairmeadowsVideos').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

//Videos from videos screen
function rpVideos2() {
    showLoading();
    PageMethods.GetVideosList2("RED", MethodResultsGetVideosListRED2);
};
function MethodResultsGetVideosListRED2(ResultsString) {
    document.getElementById('remVidResults').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function wrVideos2() {
    showLoading();
    PageMethods.GetVideosList2("WRD", MethodResultsGetVideosListWRD2);
};
function MethodResultsGetVideosListWRD2(ResultsString) {
    document.getElementById('wrVidResults').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

function fmVideos2() {
    showLoading();
    PageMethods.GetVideosList2("FM", MethodResultsGetVideosListFM2);
};
function MethodResultsGetVideosListFM2(ResultsString) {
    document.getElementById('fmVidResults').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};

//Steve Show Video Functions
function ShowVideo(flashfilename, mobilefilename) {
    var myIphone;

    myIphone = DetectIphone();

    PageMethods.GetVideoURL(flashfilename, mobilefilename, myIphone, MethodResultsGetVideo);
}
function MethodResultsGetVideo(ResultString) {
    if (currentTrack == "RED") {
        document.getElementById('remDetails').innerHTML = ResultString;
    }
    if (currentTrack == "WRD") {
        document.getElementById('wrDetails').innerHTML = ResultString;
    }
    if (currentTrack == "FM") {
        document.getElementById('fmDetails').innerHTML = ResultString;
    }
    hideLoading();
    refreshScrolls();
    currentTrack = "";
}

function ShowVideo2(flashfilename, mobilefilename) {
    var myIphone;

    myIphone = DetectIphone();

    PageMethods.GetVideoURL(flashfilename, mobilefilename, myIphone, MethodResultsGetVideo2);
}
function MethodResultsGetVideo2(ResultString) {
    if (currentTrack == "RED") {
        document.getElementById('remVidDisplay').innerHTML = ResultString;
    }
    if (currentTrack == "WRD") {
        document.getElementById('wrVidDisplay').innerHTML = ResultString;
    }
    if (currentTrack == "FM") {
        document.getElementById('fmVidDisplay').innerHTML = ResultString;
    }
    hideLoading();
    refreshScrolls();
    currentTrack = "";
}

//************************************************
// Check Device Functions
//************************************************
var deviceIphone = "iphone";
var deviceIpod = "ipod";
var deviceIpad = "ipad";

//Initialize our user agent string to lower case.
var uagent = navigator.userAgent.toLowerCase();

//**************************
// Detects if the current device is an iPhone.
function DetectIphone() {
    if (uagent.search(deviceIphone) > -1) {
        return true;
    }
    if (uagent.search(deviceIpad) > -1) {
        return true;
    }
    if (uagent.search(deviceIpod) > -1) {
        return true;
    }
    else {
        return false;
    }
}
//************************************************
// Check Device Functions
//************************************************

//Steve ShowVideoByDay - From Individual Tracks
function ShowVideoDay(dateStr) {
    showLoading();
    PageMethods.GetVideosByDay(dateStr, MethodResultsGetVideoByDay);
}
function MethodResultsGetVideoByDay(ResultString) {
    if (ResultString.detailList.track == "RED") {
        document.getElementById('remResults').innerHTML = ResultString.detailList.resultString;
        currentTrack = "RED";
    }
    if (ResultString.detailList.track == "WRD") {
        document.getElementById('wrResults').innerHTML = ResultString.detailList.resultString;
        currentTrack = "WRD";
    }
    if (ResultString.detailList.track == "FM") {
        document.getElementById('fmResults').innerHTML = ResultString.detailList.resultString;
        currentTrack = "FM";
    }
    hideLoading();
    refreshScrolls();
}

//Steve ShowVideoByDay - From Videos from home menu
function ShowVideoDay2(dateStr) {
    showLoading();
    PageMethods.GetVideosByDay2(dateStr, MethodResultsGetVideoByDay2);
}
function MethodResultsGetVideoByDay2(ResultString) {
    //alert(ResultString.detailList.track);
    if (ResultString.detailList.track == "RED") {
        document.getElementById('remVidResults2').innerHTML = ResultString.detailList.resultString;
        currentTrack = "RED";
    }
    if (ResultString.detailList.track == "WRD") {
        document.getElementById('wrVidResults2').innerHTML = ResultString.detailList.resultString;
        currentTrack = "WRD";
    }
    if (ResultString.detailList.track == "FM") {
        document.getElementById('fmVidResults2').innerHTML = ResultString.detailList.resultString;
        currentTrack = "FM";
    }
    hideLoading();
    refreshScrolls();
}

function CallMyMethod(sort) {
    showLoading();
    var guid = document.getElementById('HiddenGuid').value;
    switch (sort) {
        case 0:
            PageMethods.MyMethod(guid, sort, MyMethod_Result);
            break;
        case 1:
            PageMethods.MyMethod(guid, sort, Method_ResultTrack);
            break;
        case 2:
            PageMethods.MyMethod(guid, sort, Method_ResultTime);
            break;
        case 3:
            PageMethods.MyMethod(guid, sort, Method_ResultDistance);
            break;
        case 4:
            PageMethods.MyMethod(guid, sort, Method_ResultDate);
            break;
    }
};
function MyMethod_Result(ResultString) {
    document.getElementById('siResults').innerHTML = ResultString;
    hideLoading();
    refreshScrolls();
};
function Method_ResultTrack(ResultString) {
    document.getElementById('SavedRunsTrack').innerHTML = ResultString;
    hideLoading();
    refreshScrolls();
};
function Method_ResultTime(ResultString) {
    document.getElementById('SavedRunsTime').innerHTML = ResultString;
    hideLoading();
    refreshScrolls();
};
function Method_ResultDistance(ResultString) {
    document.getElementById('SavedRunsDistance').innerHTML = ResultString;
    hideLoading();
    refreshScrolls();
};
function Method_ResultDate(ResultString) {
    document.getElementById('SavedRunsDate').innerHTML = ResultString;
    hideLoading();
    refreshScrolls();
};

function getNews() {
    showLoading();
    PageMethods.GetNews(MethodResultsGetNews);
};
function MethodResultsGetNews(ResultsString) {
    document.getElementById('newsContent').innerHTML = ResultsString;
    hideLoading();
    refreshScrolls();
};
//End Web Methods

//******************************************************
//Start Stakes Functions
//******************************************************
function openStakesOneSlot(which) {
    switch (which) {
        case 1:
            SpinningWheel.addSlot({ 1: 'Remington Park', 2: 'Fair Meadows', 3: 'Will Rogers Downs', 4: 'All' });
            document.getElementById('StakesWhich').value = which;
            break;
        case 3:
            SpinningWheel.addSlot({ 1: 'G1', 2: 'G2', 3: 'G3', 4: 'RG1', 5: 'RG2', 6: 'RG3', 7: 'All' });
            document.getElementById('StakesWhich').value = which;
            break;
        case 4:
            SpinningWheel.addSlot({ 1: '2', 2: '3', 3: 'All' });
            document.getElementById('StakesWhich').value = which;
            break;

        case 5:
            SpinningWheel.addSlot({ 1: 'Colts and Geldings', 2: 'Fillies and Mares', 3: 'All' });
            document.getElementById('StakesWhich').value = which;
            break;
        case 6:
            SpinningWheel.addSlot({ 1: 'App', 2: 'P', 3: 'Paints and App', 3: 'Paints', 4: 'QH', 5: 'All' });
            document.getElementById('StakesWhich').value = which;
            break;

        case 7:
            SpinningWheel.addSlot({ 1: '100 yards', 2: '110 yards', 3: '220 yards', 4: '250 yards', 5: '300 yards', 6: '330 yards', 7: '350 yards', 8: '400 yards', 9: '440 yards', 10: '550 yards', 11: '660 yards', 12: '770 yards', 13: '870 yards', 14: '880 yards', 15: '1000 yards', 16: 'All' });
            document.getElementById('StakesWhich').value = which;
            break;
    }
    if (which != 2) {
        SpinningWheel.setCancelAction(cancelStakes);
        SpinningWheel.setDoneAction(doneStakes);
        SpinningWheel.open();
    }
};
function FindStakes() {
    var rt = document.getElementById('RaceTrack').innerHTML;
    var dt = "All";
    var grade = document.getElementById('RaceGrade').innerHTML;
    var age = document.getElementById('RaceAge').innerHTML;
    var breed = document.getElementById('RaceBreed').innerHTML;
    var sex = document.getElementById('RaceSex').innerHTML;
    var distance = document.getElementById('RaceDistance').innerHTML;
    showLoading();
    PageMethods.ReturnFoundRaceInfo(rt, dt, grade, age, breed, sex, distance, Method_ResultFindStakes);
};
function Method_ResultFindStakes(ResultString) {
    document.getElementById('LabelSteve').innerHTML = ResultString;
    document.getElementById('popupContainer').style.display = 'block';
    document.getElementById('PopupProfile').style.display = 'none';
    document.getElementById('PopupSteve').style.display = 'block';
    hideLoading();
    refreshScrolls();
    myScroll15.refresh();
};
function doneStakes() {
    //alert(which);
    var results = SpinningWheel.getSelectedValues();

    var SelectionId = document.getElementById('StakesWhich').value;

    switch (SelectionId) {
        case "1":
            document.getElementById('RaceTrack').innerHTML = results.values;
            break;
        case "3":
            document.getElementById('RaceGrade').innerHTML = results.values;
            break;
        case "4":
            document.getElementById('RaceAge').innerHTML = results.values;
            break;
        case "5":
            document.getElementById('RaceSex').innerHTML = results.values;
            break;
        case "6":
            document.getElementById('RaceBreed').innerHTML = results.values;
            break;
        case "7":
            document.getElementById('RaceDistance').innerHTML = results.values;
            break;
    }
};
function cancelStakes() {
};
//End Stakes Functions

//******************************************************
//Start Calendar Functions
//******************************************************
//End Calendar Functions

//******************************************************
//Start Betting Functions
//******************************************************
function hideBettingSubDivs() {
    //Disclaimer Divs
    document.getElementById('BettingDisclaimer').style.display = "none";

    //Calculate Divs
    document.getElementById('CalcOdds').style.display = "none";
    document.getElementById('CalcDaily').style.display = "none";
    document.getElementById('CalcExacta').style.display = "none";
    document.getElementById('CalcExactaPart').style.display = "none";
    document.getElementById('CalcTri').style.display = "none";
    document.getElementById('CalcTriKey').style.display = "none";

    //Explore Divs
    document.getElementById('ExploreStraight').style.display = "none";
    document.getElementById('ExploreDaily').style.display = "none";
    document.getElementById('ExploreDailyPart').style.display = "none";
    document.getElementById('ExploreExacta').style.display = "none";
    document.getElementById('ExploreExactaStraight').style.display = "none";
    document.getElementById('ExploreExactaBox').style.display = "none";
    document.getElementById('ExploreExactaPart').style.display = "none";
    document.getElementById('ExploreTri').style.display = "none";
    document.getElementById('ExploreTriStraight').style.display = "none";
    document.getElementById('ExploreTriBox').style.display = "none";
    document.getElementById('ExploreTriPart').style.display = "none";
    document.getElementById('ExploreTriKey').style.display = "none";

    //MoneySheet
    document.getElementById('MoneySheet').style.display = "none";
};
function ChooseBet() {
    hideBettingSubDivs();

    SpinningWheel.addSlot({ 1: 'Straight Win Payout', 2: 'Daily Double Wagering Cost', 3: 'Exacta Box Wagering Cost', 4: 'Exacta Part-Wheel Wagering Cost', 5: 'Trifecta Box Wagering Cost', 6: 'Trifecta Key Wagering Cost' });
    SpinningWheel.setCancelAction(cancelBet);
    SpinningWheel.setDoneAction(doneBet);
    SpinningWheel.open();
};
function openOneSlot() {
    SpinningWheel.addSlot({ 1: '100 yards', 2: '110 yards', 3: '220 yards', 4: '250 yards', 5: '300 yards', 6: '330 yards', 7: '350 yards', 8: '400 yards', 9: '440 yards', 10: '550 yards', 11: '660 yards', 12: '770 yards', 13: '870 yards', 14: '880 yards', 15: '1000 yards' });
    //SpinningWheel.addSlot({ 1: 'Ichi', 2: 'Ni', 3: 'San', 4: 'Shi', 5: 'Go' });
    SpinningWheel.setCancelAction(cancel);
    SpinningWheel.setDoneAction(done);
    SpinningWheel.open();
};
function done() {
    var results = SpinningWheel.getSelectedValues();
    if (results.values != "") {
        //alert(results.values.join(' '));
        document.getElementById('result').innerHTML = "Distance: " + results.values.join(' ');
        document.getElementById('Distance').value = results.values.join(' ');
    }
};
function cancel() {
    document.getElementById('result').innerHTML = 'cancelled!';
};
function doneBet() {
    hideBettingSubDivs();

    var results = SpinningWheel.getSelectedValues();

    if (results.values == "Straight Win Payout") {
        document.getElementById('CalcOdds').style.display = "block";
    }
    if (results.values == "Daily Double Wagering Cost") {
        document.getElementById('CalcDaily').style.display = "block";
    }
    if (results.values == "Exacta Box Wagering Cost") {
        document.getElementById('CalcExacta').style.display = "block";
    }
    if (results.values == "Exacta Part-Wheel Wagering Cost") {
        document.getElementById('CalcExactaPart').style.display = "block";
    }
    if (results.values == "Trifecta Box Wagering Cost") {
        document.getElementById('CalcTri').style.display = "block";
    }
    if (results.values == "Trifecta Key Wagering Cost") {
        document.getElementById('CalcTriKey').style.display = "block";
    }
    refreshScrolls();
};
function ExploreBets() {
    hideBettingSubDivs();

    SpinningWheel.addSlot({ 1: 'Straight Wagering', 2: 'Straight Daily Double', 3: 'Daily Double Part-Wheel', 4: 'Exacta Wagering', 5: 'Straight Exacta', 6: 'Exacta Box', 7: 'Exacta Part-Wheel', 8: 'Trifecta Wagering', 9: 'Straight Trifecta', 10: 'Trifecta Box', 11: 'Trifecta Part-Wheel', 12: 'Trifecta Key' });
    SpinningWheel.setCancelAction(cancelBet);
    SpinningWheel.setDoneAction(doneExplore);
    SpinningWheel.open();
};
function doneExplore() {
    var results = SpinningWheel.getSelectedValues();

    hideBettingSubDivs();

    if (results.values == "Straight Wagering") {
        document.getElementById('ExploreStraight').style.display = "block";
    }
    if (results.values == "Straight Daily Double") {
        document.getElementById('ExploreDaily').style.display = "block";
    }
    if (results.values == "Daily Double Part-Wheel") {
        document.getElementById('ExploreDailyPart').style.display = "block";
    }
    if (results.values == "Exacta Wagering") {
        document.getElementById('ExploreExacta').style.display = "block";
    }
    if (results.values == "Straight Exacta") {
        document.getElementById('ExploreExactaStraight').style.display = "block";
    }
    if (results.values == "Exacta Box") {
        document.getElementById('ExploreExactaBox').style.display = "block";
    }
    if (results.values == "Exacta Part-Wheel") {
        document.getElementById('ExploreExactaPart').style.display = "block";
    }
    if (results.values == "Trifecta Wagering") {
        document.getElementById('ExploreTri').style.display = "block";
    }
    if (results.values == "Straight Trifecta") {
        document.getElementById('ExploreTriStraight').style.display = "block";
    }
    if (results.values == "Trifecta Box") {
        document.getElementById('ExploreTriBox').style.display = "block";
    }
    if (results.values == "Trifecta Part-Wheel") {
        document.getElementById('ExploreTriPart').style.display = "block";
    }
    if (results.values == "Trifecta Key") {
        document.getElementById('ExploreTriKey').style.display = "block";
    }
    refreshScrolls();
};
function cancelBet() {
    //document.getElementById('result').innerHTML = 'cancelled!';
};
function calcReturns() {
    var left;
    var right;
    var amount;
    var resultsID;
    var leftValue;
    var rightValue;
    var amountValue;
    var decimal;
    var returns;

    left = document.getElementById('left');
    right = document.getElementById('right');
    amount = document.getElementById('amount');
    resultID = document.getElementById('returns');

    leftValue = left.value;
    rightValue = right.value;
    amountValue = amount.value;

    decimal = leftValue / rightValue;
    returns = decimal * amountValue;
    returns = returns + parseFloat(amountValue);

    resultID.innerHTML = 'A ' + leftValue + ' to ' + rightValue + ' straight win bet of $' + amountValue + ' would pay $' + returns;
};
function calcDaily() {
    var race1 = document.getElementById('TextBoxExacta1').value;
    var race2 = document.getElementById('TextBoxExacta2').value;
    var Bet = document.getElementById('TextBoxExactaBet').value;
    var CostID = document.getElementById('DailyReturn');

    //Cost of Daily Double Wager: # of Horses bet in 1st race * # of Horses bet in 2nd * bet amount
    var dailyCost = race1 * race2 * Bet;

    //Display Results
    if (race1 == "" || race2 == "") {
        alert("Please enter the number of horses you wish to bet on for both races.");
    }
    if (race1 != "1" && race2 != "1") {
        CostID.innerHTML = 'The wagering cost for this Daily Double Part-Wheel wager would be: $' + dailyCost + '.';
    }
    if (race1 == "1" && race2 == "1") {
        CostID.innerHTML = 'The wagering cost for a Straight Daily Double wager would be: $' + dailyCost + '.';
    }
};
function calcExacta() {
    var horses = document.getElementById('TextBoxExactaBox').value;
    var Bet = document.getElementById('TextBoxExactaBoxBet').value;
    var CostID = document.getElementById('ExactaReturn');

    if (horses == "1") {
        alert("This type of bet requires 2 or more horses.");
    }
    else if (horses == "") {
        alert("Please enter the number of horses you wish to include.");
    }
    else {
        //Formula: Numb of Horses * (Number of Horses - 1) * Bet - based on $1
        var exactaCost = horses * (parseFloat(horses) - 1) * Bet;

        CostID.innerHTML = 'The wagering cost for an Exacta Box wager such as this would be: $' + exactaCost + '.';
    }
};
function calcExactaPart() {
    var horses = document.getElementById('TextBoxExactaPart').value;
    var Bet = document.getElementById('TextBoxExactaPartBet').value;
    var CostID = document.getElementById('ExactaPartReturn');

    if (horses == "1") {
        alert("This type of bet requires 2 or more horses.");
    }
    else if (horses == "") {
        alert("Please enter the number of horses you wish to include.");
    }
    else {
        //Formula: number of horses * Bet amt.
        var exactaCost = horses * Bet;

        CostID.innerHTML = 'The wagering cost for an Exacata Part-Wheel wager such as this would be: $' + exactaCost + '.';
    }
};
function calcTri() {
    var horses = document.getElementById('TextBoxTriBox').value;
    var Bet = document.getElementById('TextBoxTriBoxBet').value;
    var CostID = document.getElementById('TriReturn');

    if (horses == "1" || horses == "2") {
        alert("This type of bet requires 3 or more horses.");
    }
    else if (horses == "") {
        alert("Please enter the number of horses you wish to include.");
    }
    else {
        //Formula: Numb of Horses * Bet * Multiplier (which increases by 2 for each number higher
        var multiplier;

        if (horses == "3") { multiplier = 2; }
        if (horses == "4") { multiplier = 6; }
        if (horses == "5") { multiplier = 12; }
        if (horses == "6") { multiplier = 20; }
        if (horses == "7") { multiplier = 30; }
        if (horses == "8") { multiplier = 42; }
        if (horses == "9") { multiplier = 56; }
        if (horses == "10") { multiplier = 72; }
        if (horses == "11") { multiplier = 90; }
        if (horses == "12") { multiplier = 110; }

        var triBoxCost = horses * multiplier;

        CostID.innerHTML = 'The wagering cost for an Trifecta Box wager such as this would be: $' + triBoxCost + '.';
    }
};
function MoneySheet() {
    hideBettingSubDivs();
    document.getElementById('MoneySheet').style.display = "block";
};
//End Betting Functions

// ************************************************************************
//  END - Our Functions
// ************************************************************************

// ************************************************************************
//  iScroll-Lite
// ************************************************************************
/**
*
* * * * * * * * * * * * * * * * * * * * * * * * * * * *
* iScroll Lite Edition based on iScroll v4.0 Beta 4
* * * * * * * * * * * * * * * * * * * * * * * * * * * *
*
* Copyright (c) 2010 Matteo Spinelli, http://cubiq.org/
* Released under MIT license
* http://cubiq.org/dropbox/mit-license.txt
*
* Last updated: 2011.03.10
*
* * * * * * * * * * * * * * * * * * * * * * * * * * * *
*
*/

; (function () {
    function iScroll(el, options) {
        var that = this, doc = document, i;

        that.wrapper = typeof el == 'object' ? el : doc.getElementById(el);
        that.wrapper.style.overflow = 'hidden';
        that.scroller = that.wrapper.children[0];
        that.scroller.style.cssText += '-webkit-transition-property:-webkit-transform;-webkit-transform-origin:0 0;-webkit-transform:' + trnOpen + '0,0' + trnClose;
        that.scroller.style.cssText += '-webkit-transition-timing-function:cubic-bezier(0.33,0.66,0.66,1);-webkit-transition-duration:0;';

        // Default options
        that.options = {
            hScroll: true,
            vScroll: true,
            bounce: has3d,
            bounceLock: false,
            momentum: has3d,
            lockDirection: true,
            hScrollbar: true,
            vScrollbar: true,
            fixedScrollbar: isAndroid,
            fadeScrollbar: (isIDevice && has3d) || !hasTouch,
            hideScrollbar: isIDevice || !hasTouch,
            scrollbarClass: '',
            onScrollStart: null,
            onScrollEnd: null
        };

        // User defined options
        for (i in options) {
            that.options[i] = options[i];
        }

        that.options.hScrollbar = that.options.hScroll && that.options.hScrollbar;
        that.options.vScrollbar = that.options.vScroll && that.options.vScrollbar;

        that.refresh();

        that._bind(RESIZE_EV, window);
        that._bind(START_EV);
        /*	that._bind(MOVE_EV);
        that._bind(END_EV);
        that._bind(CANCEL_EV);*/
    }

    iScroll.prototype = {
        x: 0, y: 0,

        handleEvent: function (e) {
            var that = this;

            switch (e.type) {
                case START_EV: that._start(e); break;
                case MOVE_EV: that._move(e); break;
                case END_EV:
                case CANCEL_EV: that._end(e); break;
                case 'webkitTransitionEnd': that._transitionEnd(e); break;
                case RESIZE_EV: that._resize(); break;
            }
        },

        _scrollbar: function (dir) {
            var that = this,
			doc = document,
			bar;

            if (!that[dir + 'Scrollbar']) {
                if (that[dir + 'ScrollbarWrapper']) {
                    that[dir + 'ScrollbarIndicator'].style.webkitTransform = ''; // Should free some mem
                    that[dir + 'ScrollbarWrapper'].parentNode.removeChild(that[dir + 'ScrollbarWrapper']);
                    that[dir + 'ScrollbarWrapper'] = null;
                    that[dir + 'ScrollbarIndicator'] = null;
                }

                return;
            }

            if (!that[dir + 'ScrollbarWrapper']) {
                // Create the scrollbar wrapper
                bar = doc.createElement('div');
                if (that.options.scrollbarClass) {
                    bar.className = that.options.scrollbarClass + dir.toUpperCase();
                } else {
                    bar.style.cssText = 'position:absolute;z-index:100;' + (dir == 'h' ? 'height:7px;bottom:1px;left:2px;right:7px' : 'width:7px;bottom:7px;top:2px;right:1px');
                }
                bar.style.cssText += 'pointer-events:none;-webkit-transition-property:opacity;-webkit-transition-duration:' + (that.options.fadeScrollbar ? '350ms' : '0') + ';overflow:hidden;opacity:' + (that.options.hideScrollbar ? '0' : '1');

                that.wrapper.appendChild(bar);
                that[dir + 'ScrollbarWrapper'] = bar;

                // Create the scrollbar indicator
                bar = doc.createElement('div');
                if (!that.options.scrollbarClass) {
                    bar.style.cssText = 'position:absolute;z-index:100;background:rgba(0,0,0,0.5);border:1px solid rgba(255,255,255,0.9);-webkit-background-clip:padding-box;-webkit-box-sizing:border-box;' + (dir == 'h' ? 'height:100%;-webkit-border-radius:4px 3px;' : 'width:100%;-webkit-border-radius:3px 4px;');
                }
                bar.style.cssText += 'pointer-events:none;-webkit-transition-property:-webkit-transform;-webkit-transition-timing-function:cubic-bezier(0.33,0.66,0.66,1);-webkit-transition-duration:0;-webkit-transform:' + trnOpen + '0,0' + trnClose;

                that[dir + 'ScrollbarWrapper'].appendChild(bar);
                that[dir + 'ScrollbarIndicator'] = bar;
            }

            if (dir == 'h') {
                that.hScrollbarSize = that.hScrollbarWrapper.clientWidth;
                that.hScrollbarIndicatorSize = m.max(m.round(that.hScrollbarSize * that.hScrollbarSize / that.scrollerW), 8);
                that.hScrollbarIndicator.style.width = that.hScrollbarIndicatorSize + 'px';
                that.hScrollbarMaxScroll = that.hScrollbarSize - that.hScrollbarIndicatorSize;
                that.hScrollbarProp = that.hScrollbarMaxScroll / that.maxScrollX;
            } else {
                that.vScrollbarSize = that.vScrollbarWrapper.clientHeight;
                that.vScrollbarIndicatorSize = m.max(m.round(that.vScrollbarSize * that.vScrollbarSize / that.scrollerH), 8);
                that.vScrollbarIndicator.style.height = that.vScrollbarIndicatorSize + 'px';
                that.vScrollbarMaxScroll = that.vScrollbarSize - that.vScrollbarIndicatorSize;
                that.vScrollbarProp = that.vScrollbarMaxScroll / that.maxScrollY;
            }

            // Reset position
            that._indicatorPos(dir, true);
        },

        _resize: function () {
            var that = this;

            //if (that.options.momentum) that._unbind('webkitTransitionEnd');

            setTimeout(function () {
                that.refresh();
            }, 0);
        },

        _pos: function (x, y) {
            var that = this;

            that.x = that.hScroll ? x : 0;
            that.y = that.vScroll ? y : 0;

            that.scroller.style.webkitTransform = trnOpen + that.x + 'px,' + that.y + 'px' + trnClose;

            that._indicatorPos('h');
            that._indicatorPos('v');
        },

        _indicatorPos: function (dir, hidden) {
            var that = this,
			pos = dir == 'h' ? that.x : that.y;

            if (!that[dir + 'Scrollbar']) return;

            pos = that[dir + 'ScrollbarProp'] * pos;

            if (pos < 0) {
                pos = that.options.fixedScrollbar ? 0 : pos + pos * 3;
                if (that[dir + 'ScrollbarIndicatorSize'] + pos < 9) pos = -that[dir + 'ScrollbarIndicatorSize'] + 8;
            } else if (pos > that[dir + 'ScrollbarMaxScroll']) {
                pos = that.options.fixedScrollbar ? that[dir + 'ScrollbarMaxScroll'] : pos + (pos - that[dir + 'ScrollbarMaxScroll']) * 3;
                if (that[dir + 'ScrollbarIndicatorSize'] + that[dir + 'ScrollbarMaxScroll'] - pos < 9) pos = that[dir + 'ScrollbarIndicatorSize'] + that[dir + 'ScrollbarMaxScroll'] - 8;
            }
            that[dir + 'ScrollbarWrapper'].style.webkitTransitionDelay = '0';
            that[dir + 'ScrollbarWrapper'].style.opacity = hidden && that.options.hideScrollbar ? '0' : '1';
            that[dir + 'ScrollbarIndicator'].style.webkitTransform = trnOpen + (dir == 'h' ? pos + 'px,0' : '0,' + pos + 'px') + trnClose;
        },

        _transitionTime: function (time) {
            var that = this;

            time += 'ms';
            that.scroller.style.webkitTransitionDuration = time;

            if (that.hScrollbar) that.hScrollbarIndicator.style.webkitTransitionDuration = time;
            if (that.vScrollbar) that.vScrollbarIndicator.style.webkitTransitionDuration = time;
        },

        _start: function (e) {
            var that = this,
			point = hasTouch ? e.changedTouches[0] : e,
			matrix;

            that.moved = false;

            e.preventDefault();

            that.moved = false;
            that.distX = 0;
            that.distY = 0;
            that.absDistX = 0;
            that.absDistY = 0;
            that.dirX = 0;
            that.dirY = 0;
            that.returnTime = 0;

            that._transitionTime(0);

            if (that.options.momentum) {
                matrix = new WebKitCSSMatrix(window.getComputedStyle(that.scroller, null).webkitTransform);
                if (matrix.m41 != that.x || matrix.m42 != that.y) {
                    that._unbind('webkitTransitionEnd');
                    that._pos(matrix.m41, matrix.m42);
                }
            }

            that.scroller.style.webkitTransitionTimingFunction = 'cubic-bezier(0.33,0.66,0.66,1)';
            if (that.hScrollbar) that.hScrollbarIndicator.style.webkitTransitionTimingFunction = 'cubic-bezier(0.33,0.66,0.66,1)';
            if (that.vScrollbar) that.vScrollbarIndicator.style.webkitTransitionTimingFunction = 'cubic-bezier(0.33,0.66,0.66,1)';
            that.startX = that.x;
            that.startY = that.y;
            that.pointX = point.pageX;
            that.pointY = point.pageY;

            that.startTime = e.timeStamp;

            if (that.options.onScrollStart) that.options.onScrollStart.call(that);

            // Registering/unregistering of events is done to preserve resources on Android
            //		setTimeout(function () {
            //			that._unbind(START_EV);
            that._bind(MOVE_EV);
            that._bind(END_EV);
            that._bind(CANCEL_EV);
            //		}, 0);
        },

        _move: function (e) {
            if (hasTouch && e.touches.length > 1) return;

            var that = this,
			point = hasTouch ? e.changedTouches[0] : e,
			deltaX = point.pageX - that.pointX,
			deltaY = point.pageY - that.pointY,
			newX = that.x + deltaX,
			newY = that.y + deltaY;

            e.preventDefault();

            that.pointX = point.pageX;
            that.pointY = point.pageY;

            // Slow down if outside of the boundaries
            if (newX > 0 || newX < that.maxScrollX) {
                newX = that.options.bounce ? that.x + (deltaX / 2.4) : newX >= 0 || that.maxScrollX >= 0 ? 0 : that.maxScrollX;
            }
            if (newY > 0 || newY < that.maxScrollY) {
                newY = that.options.bounce ? that.y + (deltaY / 2.4) : newY >= 0 || that.maxScrollY >= 0 ? 0 : that.maxScrollY;
            }

            if (that.absDistX < 4 && that.absDistY < 4) {
                that.distX += deltaX;
                that.distY += deltaY;
                that.absDistX = m.abs(that.distX);
                that.absDistY = m.abs(that.distY);
                return;
            }

            // Lock direction
            if (that.options.lockDirection) {
                if (that.absDistX > that.absDistY + 3) {
                    newY = that.y;
                    deltaY = 0;
                } else if (that.absDistY > that.absDistX + 3) {
                    newX = that.x;
                    deltaX = 0;
                }
            }

            that.moved = true;
            that._pos(newX, newY);
            that.dirX = deltaX > 0 ? -1 : deltaX < 0 ? 1 : 0;
            that.dirY = deltaY > 0 ? -1 : deltaY < 0 ? 1 : 0;

            if (e.timeStamp - that.startTime > 300) {
                that.startTime = e.timeStamp;
                that.startX = that.x;
                that.startY = that.y;
            }
        },

        _end: function (e) {
            if (hasTouch && e.touches.length != 0) return;

            var that = this,
			point = hasTouch ? e.changedTouches[0] : e,
			target, ev,
			momentumX = { dist: 0, time: 0 },
			momentumY = { dist: 0, time: 0 },
			duration = e.timeStamp - that.startTime,
			newPosX = that.x, newPosY = that.y,
			newDuration;

            //		that._bind(START_EV);
            that._unbind(MOVE_EV);
            that._unbind(END_EV);
            that._unbind(CANCEL_EV);

            if (!that.moved) {
                if (hasTouch) {
                    that.doubleTapTimer = null;

                    // Find the last touched element
                    target = point.target;
                    while (target.nodeType != 1) {
                        target = target.parentNode;
                    }

                    ev = document.createEvent('MouseEvents');
                    ev.initMouseEvent('click', true, true, e.view, 1,
					point.screenX, point.screenY, point.clientX, point.clientY,
					e.ctrlKey, e.altKey, e.shiftKey, e.metaKey,
					0, null);
                    ev._fake = true;
                    target.dispatchEvent(ev);
                }

                that._resetPos();
                return;
            }

            if (duration < 300 && that.options.momentum) {
                momentumX = newPosX ? that._momentum(newPosX - that.startX, duration, -that.x, that.scrollerW - that.wrapperW + that.x, that.options.bounce ? that.wrapperW : 0) : momentumX;
                momentumY = newPosY ? that._momentum(newPosY - that.startY, duration, -that.y, (that.maxScrollY < 0 ? that.scrollerH - that.wrapperH + that.y : 0), that.options.bounce ? that.wrapperH : 0) : momentumY;

                newPosX = that.x + momentumX.dist;
                newPosY = that.y + momentumY.dist;

                if ((that.x > 0 && newPosX > 0) || (that.x < that.maxScrollX && newPosX < that.maxScrollX)) momentumX = { dist: 0, time: 0 };
                if ((that.y > 0 && newPosY > 0) || (that.y < that.maxScrollY && newPosY < that.maxScrollY)) momentumY = { dist: 0, time: 0 };
            }

            if (momentumX.dist || momentumY.dist) {
                newDuration = m.max(m.max(momentumX.time, momentumY.time), 10);

                /*			if (newPosX > 0 || newPosX < that.maxScrollX || newPosY > 0 || newPosY < that.maxScrollY) {
                // Subtle change of scroller motion
                that.scroller.style.webkitTransitionTimingFunction = 'cubic-bezier(0.33,0.66,0.5,1)';
                if (that.hScrollbar) that.hScrollbarIndicator.style.webkitTransitionTimingFunction = 'cubic-bezier(0.33,0.66,0.5,1)';
                if (that.vScrollbar) that.vScrollbarIndicator.style.webkitTransitionTimingFunction = 'cubic-bezier(0.33,0.66,0.5,1)';
                }*/

                that.scrollTo(newPosX, newPosY, newDuration);
                return;
            }

            that._resetPos(200);
        },

        _resetPos: function (time) {
            var that = this,
			resetX = that.x,
			resetY = that.y;

            if (that.x >= 0) resetX = 0;
            else if (that.x < that.maxScrollX) resetX = that.maxScrollX;

            if (that.y >= 0 || that.maxScrollY > 0) resetY = 0;
            else if (that.y < that.maxScrollY) resetY = that.maxScrollY;

            if (resetX == that.x && resetY == that.y) {
                if (that.moved) {
                    if (that.options.onScrollEnd) that.options.onScrollEnd.call(that); 	// Execute custom code on scroll end
                    that.moved = false;
                }

                if (that.hScrollbar && that.options.hideScrollbar) {
                    that.hScrollbarWrapper.style.webkitTransitionDelay = '300ms';
                    that.hScrollbarWrapper.style.opacity = '0';
                }
                if (that.vScrollbar && that.options.hideScrollbar) {
                    that.vScrollbarWrapper.style.webkitTransitionDelay = '300ms';
                    that.vScrollbarWrapper.style.opacity = '0';
                }
                return;
            }

            // Invert ease
            if (time) {
                that.scroller.style.webkitTransitionTimingFunction = 'cubic-bezier(0.33,0.0,0.33,1)';
                if (that.hScrollbar) that.hScrollbarIndicator.style.webkitTransitionTimingFunction = 'cubic-bezier(0.33,0.0,0.33,1)';
                if (that.vScrollbar) that.vScrollbarIndicator.style.webkitTransitionTimingFunction = 'cubic-bezier(0.33,0.0,0.33,1)';
            }

            that.scrollTo(resetX, resetY, time || 0);
        },

        _transitionEnd: function (e) {
            var that = this;

            if (e) e.stopPropagation();

            that._unbind('webkitTransitionEnd');

            that._resetPos(that.returnTime);
            that.returnTime = 0;
        },

        /**
        *
        * Utilities
        *
        */
        _momentum: function (dist, time, maxDistUpper, maxDistLower, size) {
            var that = this,
			deceleration = 0.0006,
			speed = m.abs(dist) / time,
			newDist = (speed * speed) / (2 * deceleration),
			newTime = 0, outsideDist = 0;

            // Proportinally reduce speed if we are outside of the boundaries
            if (dist > 0 && newDist > maxDistUpper) {
                outsideDist = size / (6 / (newDist / speed * deceleration));
                maxDistUpper = maxDistUpper + outsideDist;
                that.returnTime = 800 / size * outsideDist + 100;
                speed = speed * maxDistUpper / newDist;
                newDist = maxDistUpper;
            } else if (dist < 0 && newDist > maxDistLower) {
                outsideDist = size / (6 / (newDist / speed * deceleration));
                maxDistLower = maxDistLower + outsideDist;
                that.returnTime = 800 / size * outsideDist + 100;
                speed = speed * maxDistLower / newDist;
                newDist = maxDistLower;
            }

            newDist = newDist * (dist < 0 ? -1 : 1);
            newTime = speed / deceleration;

            return { dist: newDist, time: m.round(newTime) };
        },

        _offset: function (el, tree) {
            var left = -el.offsetLeft,
			top = -el.offsetTop;

            if (!tree) return { x: left, y: top };

            while (el = el.offsetParent) {
                left -= el.offsetLeft;
                top -= el.offsetTop;
            }

            return { x: left, y: top };
        },

        _bind: function (type, el) {
            (el || this.scroller).addEventListener(type, this, false);
        },

        _unbind: function (type, el) {
            (el || this.scroller).removeEventListener(type, this, false);
        },

        /**
        *
        * Public methods
        *
        */
        destroy: function () {
            var that = this;

            // Remove the scrollbars
            that.hScrollbar = false;
            that.vScrollbar = false;
            that._scrollbar('h');
            that._scrollbar('v');

            // Free some mem
            that.scroller.style.webkitTransform = '';

            // Remove the event listeners
            that._unbind('webkitTransitionEnd');
            that._unbind(RESIZE_EV);
            that._unbind(START_EV);
            that._unbind(MOVE_EV);
            that._unbind(END_EV);
            that._unbind(CANCEL_EV);
        },

        refresh: function () {
            var that = this;

            that.wrapperW = that.wrapper.clientWidth;
            that.wrapperH = that.wrapper.clientHeight;
            that.scrollerW = that.scroller.offsetWidth;
            that.scrollerH = that.scroller.offsetHeight;
            that.maxScrollX = that.wrapperW - that.scrollerW;
            that.maxScrollY = that.wrapperH - that.scrollerH;
            that.dirX = 0;
            that.dirY = 0;

            that._transitionTime(0);

            that.hScroll = that.options.hScroll && that.maxScrollX < 0;
            that.vScroll = that.options.vScroll && (!that.options.bounceLock && !that.hScroll || that.scrollerH > that.wrapperH);
            that.hScrollbar = that.hScroll && that.options.hScrollbar;
            that.vScrollbar = that.vScroll && that.options.vScrollbar && that.scrollerH > that.wrapperH;

            // Prepare the scrollbars
            that._scrollbar('h');
            that._scrollbar('v');

            that._resetPos();
        },

        scrollTo: function (x, y, time, relative) {
            var that = this;

            if (relative) {
                x = that.x - x;
                y = that.y - y;
            }

            time = !time || (m.round(that.x) == m.round(x) && m.round(that.y) == m.round(y)) ? 0 : time;

            that.moved = true;

            if (time) that._bind('webkitTransitionEnd');
            that._transitionTime(time);
            that._pos(x, y);
            if (!time) setTimeout(function () { that._transitionEnd(); }, 0);
        },

        scrollToElement: function (el, time) {
            var that = this, pos;
            el = el.nodeType ? el : that.scroller.querySelector(el);
            if (!el) return;

            pos = that._offset(el);
            pos.x = pos.x > 0 ? 0 : pos.x < that.maxScrollX ? that.maxScrollX : pos.x;
            pos.y = pos.y > 0 ? 0 : pos.y < that.maxScrollY ? that.maxScrollY : pos.y;
            time = time === undefined ? m.max(m.abs(pos.x) * 2, m.abs(pos.y) * 2) : time;

            that.scrollTo(pos.x, pos.y, time);
        }
    };

    var has3d = 'WebKitCSSMatrix' in window && 'm11' in new WebKitCSSMatrix(),
	hasTouch = 'ontouchstart' in window,
	isIDevice = (/iphone|ipad/gi).test(navigator.appVersion),
	isAndroid = (/android/gi).test(navigator.appVersion),
	RESIZE_EV = 'onorientationchange' in window ? 'orientationchange' : 'resize',
	START_EV = hasTouch ? 'touchstart' : 'mousedown',
	MOVE_EV = hasTouch ? 'touchmove' : 'mousemove',
	END_EV = hasTouch ? 'touchend' : 'mouseup',
	CANCEL_EV = hasTouch ? 'touchcancel' : 'mouseup',
	trnOpen = 'translate' + (has3d ? '3d(' : '('),
	trnClose = has3d ? ',0)' : ')',
	m = Math;

    if (typeof exports !== 'undefined') exports.iScroll = iScroll;
    else window.iScroll = iScroll;
})();
// ************************************************************************
//  END iScroll-Lite
// ************************************************************************

// ************************************************************************
//  Add 2 Home
// ************************************************************************
/**
*
* * * * * * * * * * * * * * * * * * * * * * * * * * * *
*
* Copyright (c) 2011 Matteo Spinelli, http://cubiq.org/
* Released under MIT license
* http://cubiq.org/dropbox/mit-license.txt
*
* Version 1.0.1 - Last updated: 2011.02.05
*
* * * * * * * * * * * * * * * * * * * * * * * * * * * *
*
*/
; (function () {
    if (navigator.appName != "Microsoft Internet Explorer") {
        var nav = navigator,
	isIDevice = (/iphone|ipod|ipad/gi).test(nav.platform),
	isIPad = (/ipad/gi).test(nav.platform),
	isRetina = 'devicePixelRatio' in window && window.devicePixelRatio > 1,
	isSafari = nav.appVersion.match(/Safari/gi),
	hasHomescreen = 'standalone' in nav && isIDevice,
	isStandalone = hasHomescreen && nav.standalone,
	OSVersion = nav.appVersion.match(/OS \d+_\d+/g),
	platform = nav.platform.split(' ')[0],
	language = nav.language.replace('-', '_'),
	startY = startX = 0,
	expired = localStorage.getItem('_addToHome'),
	theInterval, closeTimeout, el, i, l,
	options = {
	    animationIn: 'drop', 	// drop || bubble || fade
	    animationOut: 'fade', 	// drop || bubble || fade
	    startDelay: 2000, 		// 2 seconds from page load before the balloon appears
	    lifespan: 20000, 		// 20 seconds before it is automatically destroyed
	    bottomOffset: 14, 		// Distance of the balloon from bottom
	    expire: 0, 				// Minutes to wait before showing the popup again (0 = always displayed)
	    message: '', 			// Customize your message or force a language ('' = automatic)
	    touchIcon: false, 		// Display the touch icon
	    arrow: true, 			// Display the balloon arrow
	    iterations: 100				// Internal/debug use
	},
        /* Message in various languages, en_us is the default if a language does not exist */
	intl = {
	    ca_es: 'Per instal·lar aquesta aplicació al vostre %device premeu `%icon` i llavors `Afegir a pantalla d\'inici`',
	    da_dk: 'Tilføj denne side til din %device: tryk på `%icon` og derefter `<strong>Tilføj til hjemmeskærm</strong>`.',
	    de_de: 'Installieren Sie diese App auf Ihrem %device: `%icon` antippen und dann `<strong>Zum Home-Bildschirm</strong>`.',
	    el_gr: '????????????? ????? ??? ???????? ???? ??????? ??? %device: `%icon` ???? ?????? `<strong>???????? ?? ????????</strong>`.',
	    en_us: 'For the full app and best experiance, install this web app on your %device: tap `%icon` and then `<strong>Add to Home Screen</strong>`.',
	    es_es: 'Para instalar esta app en su %device, pulse `%icon` y seleccione `<strong>Añadir a pantalla de inicio</strong>`.',
	    fr_fr: 'Ajoutez cette application sur votre %device en cliquant sur `%icon`, puis `<strong>Ajouter à l\'écran d\'accueil</strong>`.',
	    he_il: '<span dir="rtl">???? ???????? ?? ?? ?-%device ???: ??? `%icon` ??? `<strong>???? ???? ????</strong>`.</span>',
	    it_it: 'Installa questa applicazione sul tuo %device: premi su `%icon` e poi `<strong>Aggiungi a Home</strong>`.',
	    ja_jp: '?????????????%device???????????`%icon`??????`<strong>????????</strong>`?????????',
	    ko_kr: '%device? ??? ????? %icon? ?? ? "???? ??"? ?????',
	    nl_nl: 'Installeer deze webapp op uw %device: tik `%icon` en dan `<strong>Zet in beginscherm</strong>`.',
	    pt_br: 'Instale este web app em seu %device: aperte `%icon` e selecione `<strong>Adicionar à Tela Inicio</strong>`.',
	    pt_pt: 'Para instalar esta aplicação no seu %device, prima o `%icon` e depois o `<strong>Adicionar ao ecrã principal</strong>`.',
	    sv_se: 'Lägg till denna webbapplikation på din %device: tryck på `%icon` och därefter `<strong>Lägg till på hemskärmen</strong>`.'
	};

        OSVersion = OSVersion ? OSVersion[0].replace(/[^\d_]/g, '').replace('_', '.') * 1 : 0;
        expired = expired == 'null' ? 0 : expired * 1;

        // Merge options
        if (window.addToHomeConfig) {
            for (i in window.addToHomeConfig) {
                options[i] = window.addToHomeConfig[i];
            }
        }

        // Is it expired?
        if (!options.expire || expired < new Date().getTime()) {
            expired = 0;
        }

        /* Bootstrap */
        if (hasHomescreen && !expired && !isStandalone && isSafari) {
            document.addEventListener('DOMContentLoaded', ready, false);
            window.addEventListener('load', loaded, false);
        }

        /* on DOM ready */
        function ready() {
            document.removeEventListener('DOMContentLoaded', ready, false);

            var div = document.createElement('div'),
		close,
		link = options.touchIcon ? document.querySelectorAll('head link[rel=apple-touch-icon],head link[rel=apple-touch-icon-precomposed]') : [],
		sizes, touchIcon = '';

            div.id = 'addToHomeScreen';
            div.style.cssText += 'position:absolute;-webkit-transition-property:-webkit-transform,opacity;-webkit-transition-duration:0;-webkit-transform:translate3d(0,0,0);';
            div.style.left = '-9999px'; 	// Hide from view at startup

            // Localize message
            if (options.message in intl) {		// You may force a language despite the user's locale
                language = options.message;
                options.message = '';
            }
            if (options.message == '') {		// We look for a suitable language (defaulted to en_us)
                options.message = language in intl ? intl[language] : intl['en_us'];
            }

            // Search for the apple-touch-icon
            if (link.length) {
                for (i = 0, l = link.length; i < l; i++) {
                    sizes = link[i].getAttribute('sizes');

                    if (sizes) {
                        if (isRetina && sizes == '114x114') {
                            touchIcon = link[i].href;
                            break;
                        }
                    } else {
                        touchIcon = link[i].href;
                    }
                }

                touchIcon = '<span style="background-image:url(' + touchIcon + ')" class="touchIcon"></span>';
            }

            div.className = (isIPad ? 'ipad' : 'iphone') + (touchIcon ? ' wide' : '');
            div.innerHTML = touchIcon + options.message.replace('%device', platform).replace('%icon', OSVersion >= 4.2 ? '<span class="share"></span>' : '<span class="plus">+</span>') + (options.arrow ? '<span class="arrow"></span>' : '') + '<span class="close">×</span>';

            document.body.appendChild(div);
            el = div;

            // Add the close action
            close = el.querySelector('.close');
            if (close) close.addEventListener('click', addToHomeClose, false);

            // Add expire date to the popup
            if (options.expire) localStorage.setItem('_addToHome', new Date().getTime() + options.expire * 60 * 1000);
        }

        /* on window load */
        function loaded() {
            window.removeEventListener('load', loaded, false);

            setTimeout(function () {
                var duration;

                startY = isIPad ? window.scrollY : window.innerHeight + window.scrollY;
                startX = isIPad ? window.scrollX : Math.round((window.innerWidth - el.offsetWidth) / 2) + window.scrollX;

                el.style.top = isIPad ? startY + options.bottomOffset + 'px' : startY - el.offsetHeight - options.bottomOffset + 'px';
                el.style.left = isIPad ? startX + 208 - Math.round(el.offsetWidth / 2) + 'px' : startX + 'px';

                switch (options.animationIn) {
                    case 'drop':
                        if (isIPad) {
                            duration = '0.6s';
                            el.style.webkitTransform = 'translate3d(0,' + -(window.scrollY + options.bottomOffset + el.offsetHeight) + 'px,0)';
                        } else {
                            duration = '0.9s';
                            el.style.webkitTransform = 'translate3d(0,' + -(startY + options.bottomOffset) + 'px,0)';
                        }
                        break;
                    case 'bubble':
                        if (isIPad) {
                            duration = '0.6s';
                            el.style.opacity = '0'
                            el.style.webkitTransform = 'translate3d(0,' + (startY + 50) + 'px,0)';
                        } else {
                            duration = '0.6s';
                            el.style.webkitTransform = 'translate3d(0,' + (el.offsetHeight + options.bottomOffset + 50) + 'px,0)';
                        }
                        break;
                    default:
                        duration = '1s';
                        el.style.opacity = '0';
                }

                setTimeout(function () {
                    el.style.webkitTransitionDuration = duration;
                    el.style.opacity = '1';
                    el.style.webkitTransform = 'translate3d(0,0,0)';
                    el.addEventListener('webkitTransitionEnd', transitionEnd, false);
                }, 0);

                closeTimeout = setTimeout(addToHomeClose, options.lifespan);
            }, options.startDelay);
        }

        function transitionEnd() {
            el.removeEventListener('webkitTransitionEnd', transitionEnd, false);
            el.style.webkitTransitionProperty = '-webkit-transform';
            el.style.webkitTransitionDuration = '0.2s';

            if (closeTimeout) {		// Standard loop
                clearInterval(theInterval);
                theInterval = setInterval(setPosition, options.iterations);
            } else {				// We are closing
                el.parentNode.removeChild(el);
            }
        }

        function setPosition() {
            var matrix = new WebKitCSSMatrix(window.getComputedStyle(el, null).webkitTransform),
		posY = isIPad ? window.scrollY - startY : window.scrollY + window.innerHeight - startY,
		posX = isIPad ? window.scrollX - startX : window.scrollX + Math.round((window.innerWidth - el.offsetWidth) / 2) - startX;

            if (posY == matrix.m42 && posX == matrix.m41) return;

            clearInterval(theInterval);
            el.removeEventListener('webkitTransitionEnd', transitionEnd, false);
            //	el.style.webkitTransitionDuration = '0';

            setTimeout(function () {
                el.addEventListener('webkitTransitionEnd', transitionEnd, false);
                //		el.style.webkitTransitionDuration = '0.2s';
                el.style.webkitTransform = 'translate3d(' + posX + 'px,' + posY + 'px,0)';
            }, 0);
        }

        function addToHomeClose() {
            clearInterval(theInterval);
            clearTimeout(closeTimeout);
            closeTimeout = null;
            el.removeEventListener('webkitTransitionEnd', transitionEnd, false);

            var posY = isIPad ? window.scrollY - startY : window.scrollY + window.innerHeight - startY,
		posX = isIPad ? window.scrollX - startX : window.scrollX + Math.round((window.innerWidth - el.offsetWidth) / 2) - startX,
		opacity = '1',
		duration = '0',
		close = el.querySelector('.close');

            if (close) close.removeEventListener('click', addToHomeClose, false);

            el.style.webkitTransitionProperty = '-webkit-transform,opacity';

            switch (options.animationOut) {
                case 'drop':
                    if (isIPad) {
                        duration = '0.4s';
                        opacity = '0';
                        posY = posY + 50;
                    } else {
                        duration = '0.6s';
                        posY = posY + el.offsetHeight + options.bottomOffset + 50;
                    }
                    break;
                case 'bubble':
                    if (isIPad) {
                        duration = '0.8s';
                        posY = posY - el.offsetHeight - options.bottomOffset - 50;
                    } else {
                        duration = '0.4s';
                        opacity = '0';
                        posY = posY - 50;
                    }
                    break;
                default:
                    duration = '0.8s';
                    opacity = '0';
            }

            el.addEventListener('webkitTransitionEnd', transitionEnd, false);
            el.style.opacity = opacity;
            el.style.webkitTransitionDuration = duration;
            el.style.webkitTransform = 'translate3d(' + posX + 'px,' + posY + 'px,0)';
        }

        /* Public function */
        window.addToHomeClose = addToHomeClose;
    }
})();
// ************************************************************************
//  END Add 2 Home
// ************************************************************************

// Modernizr v1.7  www.modernizr.com
// PhoneID Library
window.Modernizr = function (a, b, c) { function G() { e.input = function (a) { for (var b = 0, c = a.length; b < c; b++) t[a[b]] = !!(a[b] in l); return t } ("autocomplete autofocus list placeholder max min multiple pattern required step".split(" ")), e.inputtypes = function (a) { for (var d = 0, e, f, h, i = a.length; d < i; d++) l.setAttribute("type", f = a[d]), e = l.type !== "text", e && (l.value = m, l.style.cssText = "position:absolute;visibility:hidden;", /^range$/.test(f) && l.style.WebkitAppearance !== c ? (g.appendChild(l), h = b.defaultView, e = h.getComputedStyle && h.getComputedStyle(l, null).WebkitAppearance !== "textfield" && l.offsetHeight !== 0, g.removeChild(l)) : /^(search|tel)$/.test(f) || (/^(url|email)$/.test(f) ? e = l.checkValidity && l.checkValidity() === !1 : /^color$/.test(f) ? (g.appendChild(l), g.offsetWidth, e = l.value != m, g.removeChild(l)) : e = l.value != m)), s[a[d]] = !!e; return s } ("search tel url email datetime date month week time datetime-local number range color".split(" ")) } function F(a, b) { var c = a.charAt(0).toUpperCase() + a.substr(1), d = (a + " " + p.join(c + " ") + c).split(" "); return !!E(d, b) } function E(a, b) { for (var d in a) if (k[a[d]] !== c && (!b || b(a[d], j))) return !0 } function D(a, b) { return ("" + a).indexOf(b) !== -1 } function C(a, b) { return typeof a === b } function B(a, b) { return A(o.join(a + ";") + (b || "")) } function A(a) { k.cssText = a } var d = "1.7", e = {}, f = !0, g = b.documentElement, h = b.head || b.getElementsByTagName("head")[0], i = "modernizr", j = b.createElement(i), k = j.style, l = b.createElement("input"), m = ":)", n = Object.prototype.toString, o = " -webkit- -moz- -o- -ms- -khtml- ".split(" "), p = "Webkit Moz O ms Khtml".split(" "), q = { svg: "http://www.w3.org/2000/svg" }, r = {}, s = {}, t = {}, u = [], v, w = function (a) { var c = b.createElement("style"), d = b.createElement("div"), e; c.textContent = a + "{#modernizr{height:3px}}", h.appendChild(c), d.id = "modernizr", g.appendChild(d), e = d.offsetHeight === 3, c.parentNode.removeChild(c), d.parentNode.removeChild(d); return !!e }, x = function () { function d(d, e) { e = e || b.createElement(a[d] || "div"); var f = (d = "on" + d) in e; f || (e.setAttribute || (e = b.createElement("div")), e.setAttribute && e.removeAttribute && (e.setAttribute(d, ""), f = C(e[d], "function"), C(e[d], c) || (e[d] = c), e.removeAttribute(d))), e = null; return f } var a = { select: "input", change: "input", submit: "form", reset: "form", error: "img", load: "img", abort: "img" }; return d } (), y = ({}).hasOwnProperty, z; C(y, c) || C(y.call, c) ? z = function (a, b) { return b in a && C(a.constructor.prototype[b], c) } : z = function (a, b) { return y.call(a, b) }, r.flexbox = function () { function c(a, b, c, d) { a.style.cssText = o.join(b + ":" + c + ";") + (d || "") } function a(a, b, c, d) { b += ":", a.style.cssText = (b + o.join(c + ";" + b)).slice(0, -b.length) + (d || "") } var d = b.createElement("div"), e = b.createElement("div"); a(d, "display", "box", "width:42px;padding:0;"), c(e, "box-flex", "1", "width:10px;"), d.appendChild(e), g.appendChild(d); var f = e.offsetWidth === 42; d.removeChild(e), g.removeChild(d); return f }, r.canvas = function () { var a = b.createElement("canvas"); return a.getContext && a.getContext("2d") }, r.canvastext = function () { return e.canvas && C(b.createElement("canvas").getContext("2d").fillText, "function") }, r.webgl = function () { return !!a.WebGLRenderingContext }, r.touch = function () { return "ontouchstart" in a || w("@media (" + o.join("touch-enabled),(") + "modernizr)") }, r.geolocation = function () { return !!navigator.geolocation }, r.postmessage = function () { return !!a.postMessage }, r.websqldatabase = function () { var b = !!a.openDatabase; return b }, r.indexedDB = function () { for (var b = -1, c = p.length; ++b < c; ) { var d = p[b].toLowerCase(); if (a[d + "_indexedDB"] || a[d + "IndexedDB"]) return !0 } return !1 }, r.hashchange = function () { return x("hashchange", a) && (b.documentMode === c || b.documentMode > 7) }, r.history = function () { return !!(a.history && history.pushState) }, r.draganddrop = function () { return x("dragstart") && x("drop") }, r.websockets = function () { return "WebSocket" in a }, r.rgba = function () { A("background-color:rgba(150,255,150,.5)"); return D(k.backgroundColor, "rgba") }, r.hsla = function () { A("background-color:hsla(120,40%,100%,.5)"); return D(k.backgroundColor, "rgba") || D(k.backgroundColor, "hsla") }, r.multiplebgs = function () { A("background:url(//:),url(//:),red url(//:)"); return (new RegExp("(url\\s*\\(.*?){3}")).test(k.background) }, r.backgroundsize = function () { return F("backgroundSize") }, r.borderimage = function () { return F("borderImage") }, r.borderradius = function () { return F("borderRadius", "", function (a) { return D(a, "orderRadius") }) }, r.boxshadow = function () { return F("boxShadow") }, r.textshadow = function () { return b.createElement("div").style.textShadow === "" }, r.opacity = function () { B("opacity:.55"); return /^0.55$/.test(k.opacity) }, r.cssanimations = function () { return F("animationName") }, r.csscolumns = function () { return F("columnCount") }, r.cssgradients = function () { var a = "background-image:", b = "gradient(linear,left top,right bottom,from(#9f9),to(white));", c = "linear-gradient(left top,#9f9, white);"; A((a + o.join(b + a) + o.join(c + a)).slice(0, -a.length)); return D(k.backgroundImage, "gradient") }, r.cssreflections = function () { return F("boxReflect") }, r.csstransforms = function () { return !!E(["transformProperty", "WebkitTransform", "MozTransform", "OTransform", "msTransform"]) }, r.csstransforms3d = function () { var a = !!E(["perspectiveProperty", "WebkitPerspective", "MozPerspective", "OPerspective", "msPerspective"]); a && "webkitPerspective" in g.style && (a = w("@media (" + o.join("transform-3d),(") + "modernizr)")); return a }, r.csstransitions = function () { return F("transitionProperty") }, r.fontface = function () { var a, c, d = h || g, e = b.createElement("style"), f = b.implementation || { hasFeature: function () { return !1 } }; e.type = "text/css", d.insertBefore(e, d.firstChild), a = e.sheet || e.styleSheet; var i = f.hasFeature("CSS2", "") ? function (b) { if (!a || !b) return !1; var c = !1; try { a.insertRule(b, 0), c = /src/i.test(a.cssRules[0].cssText), a.deleteRule(a.cssRules.length - 1) } catch (d) { } return c } : function (b) { if (!a || !b) return !1; a.cssText = b; return a.cssText.length !== 0 && /src/i.test(a.cssText) && a.cssText.replace(/\r+|\n+/g, "").indexOf(b.split(" ")[0]) === 0 }; c = i('@font-face { font-family: "font"; src: url(data:,); }'), d.removeChild(e); return c }, r.video = function () { var a = b.createElement("video"), c = !!a.canPlayType; if (c) { c = new Boolean(c), c.ogg = a.canPlayType('video/ogg; codecs="theora"'); var d = 'video/mp4; codecs="avc1.42E01E'; c.h264 = a.canPlayType(d + '"') || a.canPlayType(d + ', mp4a.40.2"'), c.webm = a.canPlayType('video/webm; codecs="vp8, vorbis"') } return c }, r.audio = function () { var a = b.createElement("audio"), c = !!a.canPlayType; c && (c = new Boolean(c), c.ogg = a.canPlayType('audio/ogg; codecs="vorbis"'), c.mp3 = a.canPlayType("audio/mpeg;"), c.wav = a.canPlayType('audio/wav; codecs="1"'), c.m4a = a.canPlayType("audio/x-m4a;") || a.canPlayType("audio/aac;")); return c }, r.localstorage = function () { try { return !!localStorage.getItem } catch (a) { return !1 } }, r.sessionstorage = function () { try { return !!sessionStorage.getItem } catch (a) { return !1 } }, r.webWorkers = function () { return !!a.Worker }, r.applicationcache = function () { return !!a.applicationCache }, r.svg = function () { return !!b.createElementNS && !!b.createElementNS(q.svg, "svg").createSVGRect }, r.inlinesvg = function () { var a = b.createElement("div"); a.innerHTML = "<svg/>"; return (a.firstChild && a.firstChild.namespaceURI) == q.svg }, r.smil = function () { return !!b.createElementNS && /SVG/.test(n.call(b.createElementNS(q.svg, "animate"))) }, r.svgclippaths = function () { return !!b.createElementNS && /SVG/.test(n.call(b.createElementNS(q.svg, "clipPath"))) }; for (var H in r) z(r, H) && (v = H.toLowerCase(), e[v] = r[H](), u.push((e[v] ? "" : "no-") + v)); e.input || G(), e.crosswindowmessaging = e.postmessage, e.historymanagement = e.history, e.addTest = function (a, b) { a = a.toLowerCase(); if (!e[a]) { b = !!b(), g.className += " " + (b ? "" : "no-") + a, e[a] = b; return e } }, A(""), j = l = null, f && a.attachEvent && function () { var a = b.createElement("div"); a.innerHTML = "<elem></elem>"; return a.childNodes.length !== 1 } () && function (a, b) { function p(a, b) { var c = -1, d = a.length, e, f = []; while (++c < d) e = a[c], (b = e.media || b) != "screen" && f.push(p(e.imports, b), e.cssText); return f.join("") } function o(a) { var b = -1; while (++b < e) a.createElement(d[b]) } var c = "abbr|article|aside|audio|canvas|details|figcaption|figure|footer|header|hgroup|mark|meter|nav|output|progress|section|summary|time|video", d = c.split("|"), e = d.length, f = new RegExp("(^|\\s)(" + c + ")", "gi"), g = new RegExp("<(/*)(" + c + ")", "gi"), h = new RegExp("(^|[^\\n]*?\\s)(" + c + ")([^\\n]*)({[\\n\\w\\W]*?})", "gi"), i = b.createDocumentFragment(), j = b.documentElement, k = j.firstChild, l = b.createElement("body"), m = b.createElement("style"), n; o(b), o(i), k.insertBefore(m, k.firstChild), m.media = "print", a.attachEvent("onbeforeprint", function () { var a = -1, c = p(b.styleSheets, "all"), k = [], o; n = n || b.body; while ((o = h.exec(c)) != null) k.push((o[1] + o[2] + o[3]).replace(f, "$1.iepp_$2") + o[4]); m.styleSheet.cssText = k.join("\n"); while (++a < e) { var q = b.getElementsByTagName(d[a]), r = q.length, s = -1; while (++s < r) q[s].className.indexOf("iepp_") < 0 && (q[s].className += " iepp_" + d[a]) } i.appendChild(n), j.appendChild(l), l.className = n.className, l.innerHTML = n.innerHTML.replace(g, "<$1font") }), a.attachEvent("onafterprint", function () { l.innerHTML = "", j.removeChild(l), j.appendChild(n), m.styleSheet.cssText = "" }) } (a, b), e._enableHTML5 = f, e._version = d, g.className = g.className.replace(/\bno-js\b/, "") + " js " + u.join(" "); return e } (this, this.document)
// END Modernizr

// SpinningWheel-min
var SpinningWheel = { cellHeight: 44, friction: 0.003, slotData: [], handleEvent: function (e) { if (e.type == "touchstart") { this.lockScreen(e); if (e.currentTarget.id == "sw-cancel" || e.currentTarget.id == "sw-done") { this.tapDown(e) } else { if (e.currentTarget.id == "sw-frame") { this.scrollStart(e) } } } else { if (e.type == "touchmove") { this.lockScreen(e); if (e.currentTarget.id == "sw-cancel" || e.currentTarget.id == "sw-done") { this.tapCancel(e) } else { if (e.currentTarget.id == "sw-frame") { this.scrollMove(e) } } } else { if (e.type == "touchend") { if (e.currentTarget.id == "sw-cancel" || e.currentTarget.id == "sw-done") { this.tapUp(e) } else { if (e.currentTarget.id == "sw-frame") { this.scrollEnd(e) } } } else { if (e.type == "webkitTransitionEnd") { if (e.target.id == "sw-wrapper") { this.destroy() } else { this.backWithinBoundaries(e) } } else { if (e.type == "orientationchange") { this.onOrientationChange(e) } else { if (e.type == "scroll") { this.onScroll(e) } } } } } } }, onOrientationChange: function (e) { window.scrollTo(0, 0); this.swWrapper.style.top = window.innerHeight + window.pageYOffset + "px"; this.calculateSlotsWidth() }, onScroll: function (e) { this.swWrapper.style.top = window.innerHeight + window.pageYOffset + "px" }, lockScreen: function (e) { e.preventDefault(); e.stopPropagation() }, reset: function () { this.slotEl = []; this.activeSlot = null; this.swWrapper = undefined; this.swSlotWrapper = undefined; this.swSlots = undefined; this.swFrame = undefined }, calculateSlotsWidth: function () { var div = this.swSlots.getElementsByTagName("div"); for (var i = 0; i < div.length; i += 1) { this.slotEl[i].slotWidth = div[i].offsetWidth } }, create: function () { var i, l, out, ul, div; this.reset(); div = document.createElement("div"); div.id = "sw-wrapper"; div.style.top = window.innerHeight + window.pageYOffset + "px"; div.style.webkitTransitionProperty = "-webkit-transform"; div.innerHTML = '<div id="sw-header"><div id="sw-cancel">Cancel</div><div id="sw-done">Done</div></div><div id="sw-slots-wrapper"><div id="sw-slots"></div></div><div id="sw-frame"></div>'; document.body.appendChild(div); this.swWrapper = div; this.swSlotWrapper = document.getElementById("sw-slots-wrapper"); this.swSlots = document.getElementById("sw-slots"); this.swFrame = document.getElementById("sw-frame"); for (l = 0; l < this.slotData.length; l += 1) { ul = document.createElement("ul"); out = ""; for (i in this.slotData[l].values) { out += "<li>" + this.slotData[l].values[i] + "</li>" } ul.innerHTML = out; div = document.createElement("div"); div.className = this.slotData[l].style; div.appendChild(ul); this.swSlots.appendChild(div); ul.slotPosition = l; ul.slotYPosition = 0; ul.slotWidth = 0; ul.slotMaxScroll = this.swSlotWrapper.clientHeight - ul.clientHeight - 86; ul.style.webkitTransitionTimingFunction = "cubic-bezier(0, 0, 0.2, 1)"; this.slotEl.push(ul); if (this.slotData[l].defaultValue) { this.scrollToValue(l, this.slotData[l].defaultValue) } } this.calculateSlotsWidth(); document.addEventListener("touchstart", this, false); document.addEventListener("touchmove", this, false); window.addEventListener("orientationchange", this, true); window.addEventListener("scroll", this, true); document.getElementById("sw-cancel").addEventListener("touchstart", this, false); document.getElementById("sw-done").addEventListener("touchstart", this, false); this.swFrame.addEventListener("touchstart", this, false) }, open: function () { this.create(); this.swWrapper.style.webkitTransitionTimingFunction = "ease-out"; this.swWrapper.style.webkitTransitionDuration = "400ms"; this.swWrapper.style.webkitTransform = "translate3d(0, -260px, 0)" }, destroy: function () { this.swWrapper.removeEventListener("webkitTransitionEnd", this, false); this.swFrame.removeEventListener("touchstart", this, false); document.getElementById("sw-cancel").removeEventListener("touchstart", this, false); document.getElementById("sw-done").removeEventListener("touchstart", this, false); document.removeEventListener("touchstart", this, false); document.removeEventListener("touchmove", this, false); window.removeEventListener("orientationchange", this, true); window.removeEventListener("scroll", this, true); this.slotData = []; this.cancelAction = function () { return false }; this.cancelDone = function () { return true }; this.reset(); document.body.removeChild(document.getElementById("sw-wrapper")) }, close: function () { this.swWrapper.style.webkitTransitionTimingFunction = "ease-in"; this.swWrapper.style.webkitTransitionDuration = "400ms"; this.swWrapper.style.webkitTransform = "translate3d(0, 0, 0)"; this.swWrapper.addEventListener("webkitTransitionEnd", this, false) }, addSlot: function (values, style, defaultValue) { if (!style) { style = "" } style = style.split(" "); for (var i = 0; i < style.length; i += 1) { style[i] = "sw-" + style[i] } style = style.join(" "); var obj = { values: values, style: style, defaultValue: defaultValue }; this.slotData.push(obj) }, getSelectedValues: function () { var index, count, i, l, keys = [], values = []; for (i in this.slotEl) { this.slotEl[i].removeEventListener("webkitTransitionEnd", this, false); this.slotEl[i].style.webkitTransitionDuration = "0"; if (this.slotEl[i].slotYPosition > 0) { this.setPosition(i, 0) } else { if (this.slotEl[i].slotYPosition < this.slotEl[i].slotMaxScroll) { this.setPosition(i, this.slotEl[i].slotMaxScroll) } } index = -Math.round(this.slotEl[i].slotYPosition / this.cellHeight); count = 0; for (l in this.slotData[i].values) { if (count == index) { keys.push(l); values.push(this.slotData[i].values[l]); break } count += 1 } } return { keys: keys, values: values} }, setPosition: function (slot, pos) { this.slotEl[slot].slotYPosition = pos; this.slotEl[slot].style.webkitTransform = "translate3d(0, " + pos + "px, 0)" }, scrollStart: function (e) { var xPos = e.targetTouches[0].clientX - this.swSlots.offsetLeft; var slot = 0; for (var i = 0; i < this.slotEl.length; i += 1) { slot += this.slotEl[i].slotWidth; if (xPos < slot) { this.activeSlot = i; break } } if (this.slotData[this.activeSlot].style.match("readonly")) { this.swFrame.removeEventListener("touchmove", this, false); this.swFrame.removeEventListener("touchend", this, false); return false } this.slotEl[this.activeSlot].removeEventListener("webkitTransitionEnd", this, false); this.slotEl[this.activeSlot].style.webkitTransitionDuration = "0"; var theTransform = window.getComputedStyle(this.slotEl[this.activeSlot]).webkitTransform; theTransform = new WebKitCSSMatrix(theTransform).m42; if (theTransform != this.slotEl[this.activeSlot].slotYPosition) { this.setPosition(this.activeSlot, theTransform) } this.startY = e.targetTouches[0].clientY; this.scrollStartY = this.slotEl[this.activeSlot].slotYPosition; this.scrollStartTime = e.timeStamp; this.swFrame.addEventListener("touchmove", this, false); this.swFrame.addEventListener("touchend", this, false); return true }, scrollMove: function (e) { var topDelta = e.targetTouches[0].clientY - this.startY; if (this.slotEl[this.activeSlot].slotYPosition > 0 || this.slotEl[this.activeSlot].slotYPosition < this.slotEl[this.activeSlot].slotMaxScroll) { topDelta /= 2 } this.setPosition(this.activeSlot, this.slotEl[this.activeSlot].slotYPosition + topDelta); this.startY = e.targetTouches[0].clientY; if (e.timeStamp - this.scrollStartTime > 80) { this.scrollStartY = this.slotEl[this.activeSlot].slotYPosition; this.scrollStartTime = e.timeStamp } }, scrollEnd: function (e) { this.swFrame.removeEventListener("touchmove", this, false); this.swFrame.removeEventListener("touchend", this, false); if (this.slotEl[this.activeSlot].slotYPosition > 0 || this.slotEl[this.activeSlot].slotYPosition < this.slotEl[this.activeSlot].slotMaxScroll) { this.scrollTo(this.activeSlot, this.slotEl[this.activeSlot].slotYPosition > 0 ? 0 : this.slotEl[this.activeSlot].slotMaxScroll); return false } var scrollDistance = this.slotEl[this.activeSlot].slotYPosition - this.scrollStartY; if (scrollDistance < this.cellHeight / 1.5 && scrollDistance > -this.cellHeight / 1.5) { if (this.slotEl[this.activeSlot].slotYPosition % this.cellHeight) { this.scrollTo(this.activeSlot, Math.round(this.slotEl[this.activeSlot].slotYPosition / this.cellHeight) * this.cellHeight, "100ms") } return false } var scrollDuration = e.timeStamp - this.scrollStartTime; var newDuration = (2 * scrollDistance / scrollDuration) / this.friction; var newScrollDistance = (this.friction / 2) * (newDuration * newDuration); if (newDuration < 0) { newDuration = -newDuration; newScrollDistance = -newScrollDistance } var newPosition = this.slotEl[this.activeSlot].slotYPosition + newScrollDistance; if (newPosition > 0) { newPosition /= 2; newDuration /= 3; if (newPosition > this.swSlotWrapper.clientHeight / 4) { newPosition = this.swSlotWrapper.clientHeight / 4 } } else { if (newPosition < this.slotEl[this.activeSlot].slotMaxScroll) { newPosition = (newPosition - this.slotEl[this.activeSlot].slotMaxScroll) / 2 + this.slotEl[this.activeSlot].slotMaxScroll; newDuration /= 3; if (newPosition < this.slotEl[this.activeSlot].slotMaxScroll - this.swSlotWrapper.clientHeight / 4) { newPosition = this.slotEl[this.activeSlot].slotMaxScroll - this.swSlotWrapper.clientHeight / 4 } } else { newPosition = Math.round(newPosition / this.cellHeight) * this.cellHeight } } this.scrollTo(this.activeSlot, Math.round(newPosition), Math.round(newDuration) + "ms"); return true }, scrollTo: function (slotNum, dest, runtime) { this.slotEl[slotNum].style.webkitTransitionDuration = runtime ? runtime : "100ms"; this.setPosition(slotNum, dest ? dest : 0); if (this.slotEl[slotNum].slotYPosition > 0 || this.slotEl[slotNum].slotYPosition < this.slotEl[slotNum].slotMaxScroll) { this.slotEl[slotNum].addEventListener("webkitTransitionEnd", this, false) } }, scrollToValue: function (slot, value) { var yPos, count, i; this.slotEl[slot].removeEventListener("webkitTransitionEnd", this, false); this.slotEl[slot].style.webkitTransitionDuration = "0"; count = 0; for (i in this.slotData[slot].values) { if (i == value) { yPos = count * this.cellHeight; this.setPosition(slot, yPos); break } count -= 1 } }, backWithinBoundaries: function (e) { e.target.removeEventListener("webkitTransitionEnd", this, false); this.scrollTo(e.target.slotPosition, e.target.slotYPosition > 0 ? 0 : e.target.slotMaxScroll, "150ms"); return false }, tapDown: function (e) { e.currentTarget.addEventListener("touchmove", this, false); e.currentTarget.addEventListener("touchend", this, false); e.currentTarget.className = "sw-pressed" }, tapCancel: function (e) { e.currentTarget.removeEventListener("touchmove", this, false); e.currentTarget.removeEventListener("touchend", this, false); e.currentTarget.className = "" }, tapUp: function (e) { this.tapCancel(e); if (e.currentTarget.id == "sw-cancel") { this.cancelAction() } else { this.doneAction() } this.close() }, setCancelAction: function (action) { this.cancelAction = action }, setDoneAction: function (action) { this.doneAction = action }, cancelAction: function () { return false }, cancelDone: function () { return true } };
// End SpinningWheel-min