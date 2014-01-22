#region Auto-generated classes for main database on 2014-01-22 01:01:21Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from main on 2014-01-22 01:01:21Z
// Please visit http://linq.to/db for more information

#endregion

using System;
using System.Data;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Reflection;
using DbLinq.Data.Linq;
using DbLinq.Vendor;
using System.ComponentModel;
namespace WebixDemo
{

    public partial class Main : DataContext
    {
        public Main(IDbConnection connection)
            : base(connection, new DbLinq.Sqlite.SqliteVendor())
        {
        }

        public Main(IDbConnection connection, IVendor vendor)
            : base(connection, vendor)
        {
        }

        public Table<Films> Films { get { return GetTable<Films>(); } }
        public Table<FilmsTree> FilmsTree { get { return GetTable<FilmsTree>(); } }
        public Table<PackagesPlain> PackagesPlain { get { return GetTable<PackagesPlain>(); } }
        public Table<PackagesTree> PackagesTree { get { return GetTable<PackagesTree>(); } }
    }

    [Table(Name = "main.films")]
    public partial class Films : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region int id

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "id", DbType = "integer", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    OnPropertyChanged("ID");
                }
            }
        }

        #endregion

        #region int? Rank

        private int? _rank;
        [DebuggerNonUserCode]
        [Column(Storage = "_rank", Name = "rank", DbType = "int(11)")]
        public int? Rank
        {
            get
            {
                return _rank;
            }
            set
            {
                if (value != _rank)
                {
                    _rank = value;
                    OnPropertyChanged("Rank");
                }
            }
        }

        #endregion

        #region string Rating

        private string _rating;
        [DebuggerNonUserCode]
        [Column(Storage = "_rating", Name = "rating", DbType = "varchar(20)")]
        public string Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value != _rating)
                {
                    _rating = value;
                    OnPropertyChanged("Rating");
                }
            }
        }

        #endregion

        #region string Title

        private string _title;
        [DebuggerNonUserCode]
        [Column(Storage = "_title", Name = "title", DbType = "varchar(255)")]
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value != _title)
                {
                    _title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        #endregion

        #region int? Votes

        private int? _votes;
        [DebuggerNonUserCode]
        [Column(Storage = "_votes", Name = "votes", DbType = "integer")]
        public int? Votes
        {
            get
            {
                return _votes;
            }
            set
            {
                if (value != _votes)
                {
                    _votes = value;
                    OnPropertyChanged("Votes");
                }
            }
        }

        #endregion

        #region string Year

        private string _year;
        [DebuggerNonUserCode]
        [Column(Storage = "_year", Name = "\"year\"", DbType = "varchar(4)")]
        public string Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value != _year)
                {
                    _year = value;
                    OnPropertyChanged("Year");
                }
            }
        }

        #endregion

        #region ctor

        public Films()
        {
        }

        #endregion

    }

    [Table(Name = "main.films_tree")]
    public partial class FilmsTree : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "id", DbType = "integer", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    OnPropertyChanged("ID");
                }
            }
        }

        #endregion

        #region int? Open

        private int? _open;
        [DebuggerNonUserCode]
        [Column(Storage = "_open", Name = "open", DbType = "int(1)")]
        public int? Open
        {
            get
            {
                return _open;
            }
            set
            {
                if (value != _open)
                {
                    _open = value;
                    OnPropertyChanged("Open");
                }
            }
        }

        #endregion

        #region int? Parent

        private int? _parent;
        [DebuggerNonUserCode]
        [Column(Storage = "_parent", Name = "parent", DbType = "int(11)")]
        public int? Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                if (value != _parent)
                {
                    _parent = value;
                    OnPropertyChanged("Parent");
                }
            }
        }

        #endregion

        #region string Title

        private string _title;
        [DebuggerNonUserCode]
        [Column(Storage = "_title", Name = "title", DbType = "varchar(255)")]
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value != _title)
                {
                    _title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        #endregion

        #region ctor

        public FilmsTree()
        {
        }

        #endregion

    }

    [Table(Name = "main.packages_plain")]
    public partial class PackagesPlain : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region  Architecture

        private string _architecture;
        [DebuggerNonUserCode]
        [Column(Storage = "_architecture", Name = "architecture", DbType = "")]
        public string Architecture
        {
            get
            {
                return _architecture;
            }
            set
            {
                if (value != _architecture)
                {
                    _architecture = value;
                    OnPropertyChanged("Architecture");
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "id", DbType = "INTEGER", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    OnPropertyChanged("ID");
                }
            }
        }

        #endregion

        #region  Maintainer

        private string _maintainer;
        [DebuggerNonUserCode]
        [Column(Storage = "_maintainer", Name = "maintainer", DbType = "")]
        public string Maintainer
        {
            get
            {
                return _maintainer;
            }
            set
            {
                if (value != _maintainer)
                {
                    _maintainer = value;
                    OnPropertyChanged("Maintainer");
                }
            }
        }

        #endregion

        #region  Package

        private string _package;
        [DebuggerNonUserCode]
        [Column(Storage = "_package", Name = "package", DbType = "")]
        public string Package
        {
            get
            {
                return _package;
            }
            set
            {
                if (value != _package)
                {
                    _package = value;
                    OnPropertyChanged("Package");
                }
            }
        }

        #endregion

        #region  Priority

        private string _priority;
        [DebuggerNonUserCode]
        [Column(Storage = "_priority", Name = "priority", DbType = "")]
        public string Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                if (value != _priority)
                {
                    _priority = value;
                    OnPropertyChanged("Priority");
                }
            }
        }

        #endregion

        #region  Section

        private string _section;
        [DebuggerNonUserCode]
        [Column(Storage = "_section", Name = "section", DbType = "")]
        public string Section
        {
            get
            {
                return _section;
            }
            set
            {
                if (value != _section)
                {
                    _section = value;
                    OnPropertyChanged("Section");
                }
            }
        }

        #endregion

        #region  Size

        private string _size;
        [DebuggerNonUserCode]
        [Column(Storage = "_size", Name = "size", DbType = "")]
        public string Size
        {
            get
            {
                return _size;
            }
            set
            {
                if (value != _size)
                {
                    _size = value;
                    OnPropertyChanged("Size");
                }
            }
        }

        #endregion

        #region  Version

        private string _version;
        [DebuggerNonUserCode]
        [Column(Storage = "_version", Name = "version", DbType = "")]
        public string Version
        {
            get
            {
                return _version;
            }
            set
            {
                if (value != _version)
                {
                    _version = value;
                    OnPropertyChanged("Version");
                }
            }
        }

        #endregion

        #region ctor

        public PackagesPlain()
        {
        }

        #endregion

    }

    [Table(Name = "main.packages_tree")]
    public partial class PackagesTree : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region int? HasKids

        private int? _hasKids;
        [DebuggerNonUserCode]
        [Column(Storage = "_hasKids", Name = "has_kids", DbType = "INTEGER")]
        public int? HasKids
        {
            get
            {
                return _hasKids;
            }
            set
            {
                if (value != _hasKids)
                {
                    _hasKids = value;
                    OnPropertyChanged("HasKids");
                }
            }
        }

        #endregion

        #region int? Hours

        private int? _hours;
        [DebuggerNonUserCode]
        [Column(Storage = "_hours", Name = "hours", DbType = "INTEGER")]
        public int? Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value != _hours)
                {
                    _hours = value;
                    OnPropertyChanged("Hours");
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "id", DbType = "INTEGER", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    OnPropertyChanged("ID");
                }
            }
        }

        #endregion

        #region int? ParentID

        private int? _parentID;
        [DebuggerNonUserCode]
        [Column(Storage = "_parentID", Name = "parent_id", DbType = "INTEGER")]
        public int? ParentID
        {
            get
            {
                return _parentID;
            }
            set
            {
                if (value != _parentID)
                {
                    _parentID = value;
                    OnPropertyChanged("ParentID");
                }
            }
        }

        #endregion

        #region string State

        private string _state;
        [DebuggerNonUserCode]
        [Column(Storage = "_state", Name = "state", DbType = "")]
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                if (value != _state)
                {
                    _state = value;
                    OnPropertyChanged("State");
                }
            }
        }

        #endregion

        #region  Value

        private string _value;
        [DebuggerNonUserCode]
        [Column(Storage = "_value", Name = "value", DbType = "")]
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value != _value)
                {
                    _value = value;
                    OnPropertyChanged("Value");
                }
            }
        }

        #endregion

        #region ctor

        public PackagesTree()
        {
        }

        #endregion

    }
}