using System;
using System.Collections.Generic;
using SQLite;

namespace OQHRA2011
{
    public class Areas
    {
        public string DisplayName { get; set; }
        public string KeyName { get; set; }
        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[Areas: DisplayName={0}, KeyName={1}]", DisplayName, KeyName);
        }

    }

    public class Control
    {
        public DateTime LastUpdate { get; set; }
        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[Areas: LastUpdate={0}]", LastUpdate);
        }

    }

    public class AdditionalImages
    {
        public string PropertyID { get; set; }
        public string ImageName { get; set; }
        public string Location { get; set; }
        public string Id { get; set; }
        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[AdditionalImages: PropertyID={0}, ImageName={1}, Location={2}, Id={3}]", PropertyID, ImageName, Location, Id);
        }
    }

    public class Menu
    {
        public string MenuName { get; set; }
        public int MenuId { get; set; }
        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[Menu: MenuName={0}, MenuId={1}]", MenuName, MenuId);
        }
    }

    public class RaceInfoMenu
    {
        public string MenuName { get; set; }
        public int MenuId { get; set; }
        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[RaceInfoMenu: MenuName={0}, MenuId={1}]", MenuName, MenuId);
        }
    }

    public class RaceInfoFull
    {
        public string RACETRACK { get; set; }
        public string RACENAME { get; set; }
        public string GRADE { get; set; }
        public string DATE { get; set; }
        public string OKBRED { get; set; }
        public string SEX { get; set; }
        public string AGE { get; set; }
        public string BREED { get; set; }
        public string DISTANCE { get; set; }
        public string ESTIMATED { get; set; }
        public string ADD_GUARANTEE { get; set; }
        public string NOM_CLOSINGDATE { get; set; }
        public override string ToString()
        {
            return string.Format("[RaceInfoFull: RACETRACK={0}, RACENAME={1},GRADE={3},DATE={4},OKBRED={5},SEX={6},AGE={7},BREED={8},DISTANCE={9},ESTIMATED ={10},ADD_GUARANTEE={11},NOM_CLOSINGDATE={12}]", RACETRACK, RACENAME, GRADE, DATE, OKBRED, SEX, AGE, BREED, DISTANCE, ESTIMATED, ADD_GUARANTEE, NOM_CLOSINGDATE);
        }
    }

    public class DevelopmentsDB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public string Bio { get; set; }
        public string TwitterName { get; set; }
        public string BlogUrl { get; set; }

        public string Developments { get; set; }
        public string Address { get; set; }
        public string CIty { get; set; }
        public string Builder { get; set; }
        public string Region { get; set; }

        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[Speaker: Id={0}, Name={1}, Position={2}, Company={3}, Bio={4}, TwitterName={5}, BlogUrl={6}]", Id, Name, Position, Company, Bio, TwitterName, BlogUrl);
        }
    }

    public class POH2010
    {
        public int Serial { get; set; }
        public int Id { get; set; }
        public string Company { get; set; }
        public string Addition { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public string Builder { get; set; }
        public string Area { get; set; }
        public string Phone { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Resolution { get; set; }
        public string CustomMap { get; set; }
        public string UserNotes { get; set; }
        public string propNotes { get; set; }
        public string ImageName { get; set; }
        public bool IsElite { get; set; }
        public bool IsProtected { get; set; }
        public bool IsSponsor { get; set; }
        public string AdditionalInfo { get; set; }
        public string Email { get; set; }
        public string AdditionalImages { get; set; }
        public int OnlineID { get; set; }
        public bool HouseInfoUpdated { get; set; }

        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[POH2010: Serial={0}, Id={1}, Company={2}, Addition={3}, Address={4}, Notes={5}, Builder={6}, Area={7}, Phone={8}, Latitude={9}, Longitude={10}, Resolution={11}, CustomMap={12}, UserNotes{13}, propNotes{14}, ImageName={15}, IsElite={16}, IsProtected={17}, IsSponsor={18}, AdditionalInfo={19}, Email={20}, AssitionalImages={21}, OnlineId={22}, HouseInfoUpdated={23} ]", Serial, Id, Company, Addition, Address, Notes, Builder, Area, Phone, Latitude, Longitude, Resolution, CustomMap, UserNotes, propNotes, ImageName, IsElite, IsProtected, IsSponsor, AdditionalInfo, Email, AdditionalImages, OnlineID, HouseInfoUpdated);
        }
    }


    public class Favorites
    {
        public int FavID { get; set; }
        public int FaveType { get; set; }
        public string FavLabel { get; set; }
        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[Favorites: FavID={0}, FaveType={1}, FavLabel={2}]", FavID, FaveType, FavLabel);
        }
    }

    public class Featured
    {
        public string FeatName { get; set; }
        public int FeatID { get; set; }

        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[Featured: FeatName={0}, FeatID={1}]", FeatName, FeatID);
        }
    }

    public class HorsemanMenus
    {
        public string MenuName { get; set; }
        public int MenuID { get; set; }

        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[HorsemanMenus: MenuName={0}, MenuID={1}]", MenuName, MenuID);
        }
    }

    public class SavedRunsList
    {
        public string HorseName { get; set; }
        public string Track { get; set; }
        public float RunTime { get; set; }
        public string DateRan { get; set; }
        public int Distance { get; set; }

        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[SavedRunsList: HorseName={0}, Track={1}, RunTime={1}, DateRan={1}, Distance={1}]", HorseName, Track, RunTime, DateRan, Distance);
        }
    }

    public class SpeedIndex
    {
        public int SI { get; set; }
        public string Track { get; set; }
        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[SpeedIndex: SI={0}, Track={1}]", SI, Track);
        }
    }

    public class InfoMenu
    {
        public string MenuName { get; set; }
        public string MenuTerm { get; set; }
        public int MenuId { get; set; }
        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[InfoMenu: MenuName={0}, MenuId={1}, MenuTerm={2}]", MenuName, MenuId, MenuTerm);
        }
    }

    public class RIPickerMenu
    {
        public string RetMenu { get; set; }
        public int ROWID { get; set; }
        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[RIPickerMenu: RetMenu={0}, ROWID={1}]", RetMenu, ROWID);
        }
    }

    public class LearningCenterInfo
    {
        public string Key { get; set; }
        public string Content { get; set; }
        public string Info { get; set; }
        /// <summary>
        /// For debugging, I really like the 'default' implementation suggested by MonoDevelop
        /// </summary>
        public override string ToString()
        {
            return string.Format("[LearningCenterInfo: Key={0}, Content={1}, Info={2}]", Key, Content, Info);
        }
    }

    public class Stream
    {
        public string Name { get; set; }
    }

    public class SessionDate
    {
        public string Date { get; set; }
    }

    public class Database : SQLiteConnection
    {
        public Database(string path)
            : base(path)
        {
            CreateTable<Areas>();
        }

        public IEnumerable<POH2010> GetDevelopmentProps(string development)
        {
            //Console.WriteLine("GetDevelopmentProps: " + development);    
            return Query<POH2010>("select * from POH2010 where Addition=? ", development);
        }

        public IEnumerable<Featured> GetFeaturedMenu()
        {
            return Query<Featured>("select * from Featured");
        }

        public IEnumerable<Areas> GetAreas()
        {
            //Console.WriteLine("GetAreas");    
            return Query<Areas>("select * from Areas");
        }

        public IEnumerable<Menu> GetMenus()
        {
            //Console.WriteLine("GetAreas");    
            return Query<Menu>("select * from Menu");
        }

        public IEnumerable<SavedRunsList> GetSavedRuns(int which)
        {
            //Console.WriteLine("GetAreas");    
            string SortField = "";
            switch (which)
            {
                case 0:
                    SortField = "HorseName";
                    break;
                case 1:
                    SortField = "Track";
                    break;
                case 2:
                    SortField = "RunTime";
                    break;
                case 3:
                    SortField = "Distance";
                    break;
                case 4:
                    SortField = "date('DateRan')";
                    break;
            }
            return Query<SavedRunsList>("select * from FTH_History order by " + SortField + " asc");
        }

        public IEnumerable<SpeedIndex> GetSI(string FieldName, float timeRan, string trackName)
        {
            FieldName = "a" + FieldName;
            return Query<SpeedIndex>("select * from SpeedIndex where " + FieldName + " >= " + timeRan.ToString() + " and track='" + trackName + "' limit 1");
        }

        public IEnumerable<Favorites> GetFave(int FaveT)
        {
            //Console.WriteLine("GetAreas");    
            return Query<Favorites>("select * from Favorites where FaveType=" + FaveT.ToString());
        }

        public IEnumerable<InfoMenu> GetRIMenus()
        {
            //Console.WriteLine("GetAreas");    
            return Query<InfoMenu>("select *, 'All' as MenuTerm from RaceInfoMenu");
        }

        public IEnumerable<HorsemanMenus> GetHorsemanMenus()
        {
            //Console.WriteLine("GetAreas");    
            return Query<HorsemanMenus>("select * from HorsemanMenu");
        }

        public IEnumerable<RIPickerMenu> GetPickerMenu(string WhichField)
        {
            //Console.WriteLine("select distinct " + WhichField + " as RetMenu from RaceInfo where not isnull(" + WhichField + ")");    
            //string sdfdf = "select distinct " + WhichField + " as RetMenu from RaceInfo where not isnull(" + WhichField + ")";

            if (WhichField == "distance2")
            {
                return Query<RIPickerMenu>("select distance as RetMenu,serial as ROWID from SIList order by RetMenu asc");
            }
            else
            {
                if (WhichField == "MyHorses")
                {
                    return Query<RIPickerMenu>("select distinct HorseName as RetMenu from FTH_History");
                }
                else
                {
                    return Query<RIPickerMenu>("select distinct trim(" + WhichField + ") as RetMenu from RaceInfo where " + WhichField + " <> 'NULL'");
                }
            }
        }

        public IEnumerable<POH2010> GetFeaturedNeighborhoods(string region)
        {
            return Query<POH2010>("select distinct Addition from POH2010 where addition=?", region);
        }

        public void UpdateCustomMap(int houseID)
        {
            Execute("update POH2010 set CustomMap=1 where id=?", houseID);
        }

        public int UpdateUserNotes(string unotes, string id)
        {
            return Execute("update POH2010 set userNotes='" + unotes.Replace("'", "''") + "' where Id=" + id, "");
        }

        public IEnumerable<LearningCenterInfo> GetLearningCenter(string infoSearch)
        {
            //Console.WriteLine("GetAreas");    
            return Query<LearningCenterInfo>("select * from Learning where Info=" + infoSearch);
        }

        public IEnumerable<LearningCenterInfo> GetLearningCenterKey(string key)
        {
            //Console.WriteLine("GetAreas");    
            return Query<LearningCenterInfo>("select * from Learning where key='" + key + "'");
        }

        public IEnumerable<POH2010> GetHome(string id)
        {
            //Console.WriteLine("GetHome: ");    
            return Query<POH2010>("select * from POH2010 where id=?", id);
        }

        public IEnumerable<RaceInfoFull> GetRaceInfo(string sqlStr)
        {
            //Console.WriteLine("GetHome: ");    
            return Query<RaceInfoFull>(sqlStr);
        }

        public IEnumerable<Control> GetUpdateDate()
        {
            //Console.WriteLine("GetHome: ");    
            return Query<Control>("select * from Control");
        }

        public IEnumerable<POH2010> GetCustomHomes()
        {
            //Console.WriteLine("GetCustomHome: ");
            return Query<POH2010>("select * from POH2010 where CustomMap=1");
        }

        public IEnumerable<POH2010> GetAllHomes(string area)
        {
            //Console.WriteLine("Get AllHomes: " + area);
            return Query<POH2010>("select * from POH2010 where Area=?", area);
        }

        public IEnumerable<POH2010> GetAdditionalImages(string id)
        {
            return Query<POH2010>("select * from AdditionalImages where PropertyID=?", id);
        }

        public IEnumerable<POH2010> GetHomes(string region)
        {
            //Console.WriteLine("GetHomes: ");
            return Query<POH2010>("select distinct Addition,Area from POH2010 where area=? order by addition asc", region);
        }
    }
}
