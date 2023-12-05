using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Threading;
using System.Security.Cryptography.X509Certificates;


namespace ProjectICT
{
    class Leds
    {

		private byte comData;

		public byte ComData
		{
			get 
			{ 
				return comData;
			}
			set 
			{ 
				comData = value;
                string binaire = Convert.ToString(comData, 2).PadLeft(8, '0');
                ToLeds(binaire);
			}
		}


       




        private bool led1;

		public bool Led1
		{
			get { return led1; }
			set { led1 = value; }
		}

        private bool led2;

        public bool Led2
        {
            get { return led2; }
            set { led2 = value; }
        }

        private bool led3;

        public bool Led3
        {
            get { return led3; }
            set { led3 = value; }
        }

        private bool led4;

        public bool Led4
        {
            get { return led4; }
            set { led4 = value; }
        }

        private bool led5;

        public bool Led5
        {
            get { return led5; }
            set { led5 = value; }
        }

        private bool led6;

        public bool Led6
        {
            get { return led6; }
            set { led6 = value; }
        }

        private bool led7;

        public bool Led7
        {
            get { return led7; }
            set { led7 = value; }
        }

        private bool led8;

        public bool Led8
        {
            get { return led8; }
            set { led8 = value; }
        }



        

		


		

		private void ToLeds (string data)
		{
			


            if (data[7] == '1' )
			{
				led1 = true;
                
            }
			else
			{
                led1 = false;
            }
                

            if (data[6] == '1')
            {
				led2 = true;
			}  
            else
			{
				led2 = false;
			}
                

            if (data[5] == '1')
            {
				led3 = true;
			}    
            else
			{
				led3 = false;
			}
                

            if (data[4] == '1')
            {
				led4 = true;
			}   
            else
			{
				led4 = false;
			}
                

            if (data[3] == '1')
            {
				led5 = true;
			}   
            else
			{
				led5 = false;
			}
                

            if (data[2] == '1')
            {
				led6 = true;
			}   
            else
			{
				led6 = false;
			}
                

            if (data[1] == '1')
            {
				led7 = true;
			} 
            else
			{
				led7 = false;
			}
                

            if (data[0] == '1')
            {
				led8 = true;
			}  
            else
			{
				led8 = false;
			}

            


        }

        



    }


	
}
