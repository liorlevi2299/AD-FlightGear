﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace AD_FlightGear
{
    class DBflightGear
    {
        public string[] _ListLine
        {
            get; set;
        }
        public string _PathCsv
        {
            get; set;
        }
        public string _PathXml
        {
            get; set;
        }
        public List<string> _ListFeature = new List<string>();
        public Dictionary<string, MapVector> _DictMapVector = new Dictionary<string, MapVector>();


        public void createListLines()
        {
            _ListLine = File.ReadAllLines(_PathCsv);
        }
        public void createListDataFeature()
        {
            XmlDocument reader = new XmlDocument();
            reader.Load(_PathXml);
            XmlNodeList NodeList = reader.GetElementsByTagName("node");
            XmlNodeList NameList = reader.GetElementsByTagName("name");

            int size = NodeList.Count;

            for (int i = 0; i < size; i ++)
            {
                _ListFeature.Add(NodeList[i].InnerText);
                if (NodeList[i].InnerText.Equals(_ListFeature[0]) && (i > 0))
                {
                    _ListFeature.RemoveAt(_ListFeature.Count - 1);
                    //_ListMapVector.Remove();
                    break;
                }
                MapVector mapVector = new MapVector(NameList[i].InnerText);
                _DictMapVector.Add(NodeList[i].InnerText, mapVector);
            }
        }
        public void createVectors()
        {

            int row = _ListLine.Length;
            for (int i = 0; i < row; i++)
            {
                string[] words = _ListLine[i].Split(',');
                int col = words.Length;

                for (int j = 0; j < col; j++)
                {
                    _DictMapVector[_ListFeature[j]]._vectorFloat.Add(float.Parse(words[j]));
                }
            }
        }
        public void InitializeDB()
        {
            createListLines();
            createListDataFeature();
            createVectors();
        }
    }
}



