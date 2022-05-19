using System.Collections.Generic;
namespace Parcels.Models
{
    public class Container
    {
        private static List<Container> _containers = new List<Container>{};
        public string Product{get; set;}
        public float Length{get; set;}
        public float Breadth{get; set;}
        public float Height{get; set;}
        public float Weight{get; set;}

        public Container (string product , float length , float breadth , float height , float weight)
        {
            Product = product;
            Length = length;
            Breadth = breadth;
            Height = height;
            Weight = weight;
            _containers.Add(this);
        }

        public float Volume()
        {
            return Length * Breadth * Height;
        }
        
        public static List<Container> GetAllContainers()
        {
            return _containers;
        }
        public int CostToShip()
        {
            int weightOfParcel = ((int)Weight);
            int volumeValue = ((int)Volume());
            if(volumeValue < 500)
            {
                return 100 * weightOfParcel;
            }
            else if(volumeValue < 1000)
            {
                return 500 * weightOfParcel;
            }
            else if(volumeValue < 300)
            {
                return 1000 * weightOfParcel;
            }
            else if(volumeValue < 700)
            {
                return 3000 * weightOfParcel;
            }
            else if(volumeValue < 20000)
            {
                return 7000 * weightOfParcel;
            }
            else
            {
                return 10000 * weightOfParcel;
            }
        }
    }
}