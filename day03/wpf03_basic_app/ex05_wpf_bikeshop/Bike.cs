using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ex05_wpf_bikeshop
{
    // Notifier를 상속받으면 AutoProperty {get;set;}은 사용할 수 없음
    internal class Bike: Notifier
    {
        private double speed;
        private Color color;

        public double Speed
        {
            get { return speed; } // 속성
            set { 
                speed = value; 
                // 속성값이 변경되는 것을 알려주려면 반드시 이 작업 필요
                OnPropertyChanged(nameof(Speed)); // "Speed"
            }
        }

        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged(nameof(Color));
            }
        }
    }
}
