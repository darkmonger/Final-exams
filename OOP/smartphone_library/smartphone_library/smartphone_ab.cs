using System;

namespace smartphone_library
{
    public abstract class Smartphone
    {
        public abstract string start();
       

        
        
    }

    public   class iphone : Smartphone
    {
        private string model_name;

        public iphone () {}

        

        public string GetOS()
        {
            return ("IOS 11 is working");
        }

        public  override string start()
        {
            return ("I am ready");
        }

        private int battery = 55;
        public int GetBattery()
        {
            return battery;
        }

        public string GetWeather()
        {
            return ("Today weater is sunny");
        }
        private string modelName = "iphone 13";
        public string getname() 
        {

            return modelName;
        }
    }

    public class Samsung : Smartphone
    {
        private string model_name;

        public override string start()
        {
            return ("I am ready");
        }

        public Samsung(string name)
        {
            this.model_name = name;
        }


        public string GetOS()
        {
            return ("Android 11  is working");
        }

        private int battery = 100;
        
        
        public int GetBattery()
        {

            return battery;
        }

        public string GetWeather()
        {
            return ("Today weater is sunny");
        }

        

        public Samsung () {}

        private string modelName = "Samsung S21";
        private string Getname()
        {
            return modelName;
            
        }
    }
}
