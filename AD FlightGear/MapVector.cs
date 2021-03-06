using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_FlightGear
{
    /*
     * Object for element in Data Base
     * 
     */
    public class MapVector
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string node;
        public string Node
        {
            get { return node; }
            set { node = value; }
        }
        public int index;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public List<float> _vectorFloat
        {
            get; set;
        }
        private int corrIndex;
        public int CorrIndex
        {
            get
            {
                return corrIndex;
            }
            set
            {
                corrIndex = value;
            }
        }
        private double corrResult;
        public double CorrResult
        {
            get
            {
                return corrResult;
            }
            set
            {
                corrResult = value;
            }
        }

        public MapVector(string nameFeature, string type, string node, int i)
        {
            Name = nameFeature;
            Type = type;
            Node = node;
            _vectorFloat = new List<float>();
            Index = i;
        }
    }
}
