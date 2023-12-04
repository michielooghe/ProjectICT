using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Threading;

namespace ProjectICT
{
    class Leds
    {
        Brush filledBrush = Brushes.Yellow;
        Brush transparentBrush = Brushes.Transparent;


        private bool toggle1;

		public bool  Toggle1
		{
			get { return toggle1; }
			set { toggle1 = value; }
		}

		private bool toggle2;

        public bool Toggle2
        {
            get { return toggle2; }
            set { toggle2 = value; }
        }


        private bool toggle3;

        public bool Toggle3
        {
            get { return toggle3; }
            set { toggle3 = value; }
        }

        private bool toggle4;

        public bool Toggle4
        {
            get { return toggle4; }
            set { toggle4 = value; }
        }


        private int teller;


		private int comData;

		public int ComData
		{
			get 
			{ 
				return comData;
			}
			set 
			{ 
				comData = value;
				Toggle();
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



        public void Reset()
		{
			ByteToLeds(0);
			teller = 0;
		
		}

		private void Toggle()
		{
			if (comData == 1) 
			{ 
				toggle1 = !toggle1;
				toggle2 = false;
				toggle3 = false;
				toggle4 = false;

			}
			if (comData == 2) 
			{
				toggle2 = !toggle2;
                toggle1 = false;
                toggle3 = false;
                toggle4 = false;
            }
			if (comData == 3) 
			{
				toggle3 = !toggle3;
                toggle1 = false;
                toggle2 = false;
                toggle4 = false;
            }
			if (comData == 4)
			{ 
				toggle4 = !toggle4;
                toggle1 = false;
                toggle2 = false;
                toggle3 = false;
            }
		
		}


		public void Aansturen()
		{
			if (toggle1 == true)
			{
				if (teller == 0 || teller ==9) { teller = 1; }
				
				ByteToLeds(teller);
				teller++;
				
			}
			if (toggle2 == true)
			{
				

			}
			if (toggle3 == true)
			{

			}
			if (toggle4 == true)
			{

			}


		}

		private void ByteToLeds (int data)
		{
			


            if (data == 1 )
			{
				led1 = true;
                
            }
			else
			{
                led1 = false;
            }
                

            if (data == 2)
            {
				led2 = true;
			}  
            else
			{
				led2 = false;
			}
                

            if (data == 3)
            {
				led3 = true;
			}    
            else
			{
				led3 = false;
			}
                

            if (data == 4)
            {
				led4 = true;
			}   
            else
			{
				led4 = false;
			}
                

            if (data == 5)
            {
				led5 = true;
			}   
            else
			{
				led5 = false;
			}
                

            if (data == 6)
            {
				led6 = true;
			}   
            else
			{
				led6 = false;
			}
                

            if (data == 7)
            {
				led7 = true;
			} 
            else
			{
				led7 = false;
			}
                

            if (data == 8)
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
