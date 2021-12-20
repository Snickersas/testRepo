using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore
{
    public struct Book
    {
        //prop   tab tab sukuria property

        private int TestProperty { get; set; }

        private string _name;
        private string _id;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            { 
               _name= value;
                CreateLocalId();
            }
        
        }



        public string Id
        { 
        get 
            { 
                return _id; 
            }
        
        set 
            { 
                _id= value; 
                CreateLocalId();
            } 
        }

        public string LocalId { get; private set; } //sutrumpinta, praktikoje taip ir rasoma private jeigu norim ne public, nes public defaultinis

        public Book(string name, string id)
        {
            _name = name;
            _id = id;
            LocalId = string.Empty;
            CreateLocalId();
        }

        private void CreateLocalId()
        {
            LocalId = string.Format("{0}_{1}", Name, Id);
        
        }


    }
}
