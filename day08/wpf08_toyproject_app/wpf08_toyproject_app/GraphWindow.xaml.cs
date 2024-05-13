using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using wpf08_toyproject_app.Models;
using CefSharp.DevTools.Network;
using System.Collections.Generic;
using System.Linq;



namespace wpf08_toyproject_app
{
    /// <summary>
    /// GraphWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GraphWindow : MetroWindow
    {

        public GraphWindow()
        {
            InitializeComponent();
        }

        private async void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            string openApiUri = "https://api.odcloud.kr/api/3080514/v1/uddi:a3cd4e3f-3ec4-41ef-9a9d-9d8e3d900522?page=1&perPage=10&returnType=JSON&serviceKey=ZXOeFsS2T%2BOaPtPG%2BXZ1uH7mmOAJjCr20kc3pO14E1yPqAG7ECyd9m%2BSw3aJJ59TLlnPz4t91RGlhZTuW29oGg%3D%3D";
            string result = string.Empty;

            // WebRequest, WebResponse 객체
            WebRequest req = null;
            WebResponse res = null;
            StreamReader reader = null;

            try
            {
                req = WebRequest.Create(openApiUri);
                res = await req.GetResponseAsync();
                reader = new StreamReader(res.GetResponseStream());
                result = reader.ReadToEnd();

                //await this.ShowMessageAsync("결과", result);
                Debug.WriteLine(result);
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("오류", $"OpenAPI 조회오류 {ex.Message}");
            }

            var jsonResult = JObject.Parse(result);
            var status = Convert.ToInt32(jsonResult["currentCount"]);

            if (status > 0)
            {
                var data = jsonResult["data"];
                var jsonArray = data as JArray; // json 자체에서 []안에 들어간 배열 테이터만 JArray 변환 가능

                var Population = new List<population>();
                foreach (var item in jsonArray)
                {

                    Population.Add(new population()
                    {
                        Location = Convert.ToString(item["구분"]),
                        TotalOvereighteen = Convert.ToInt32(item["18세이상인구수(계)"]),
                        Eighteenman = Convert.ToInt32(item["18세이상인구수(남)"]),
                        Eighteenwoman = Convert.ToInt32(item["18세이상인구수(여)"]),
                        Totalsixtyfive = Convert.ToInt32(item["65세이상인구수(계)"]),
                        Sixtyfiveman = Convert.ToInt32(item["65세이상인구수(남)"]),
                        sixtyfivewoman = Convert.ToInt32(item["65세이상인구수(여)"]),
                        Allpop = Convert.ToInt32(item["인구수(계)"]),
                        popman = Convert.ToInt32(item["인구수(남)"]),
                        popwoman = Convert.ToInt32(item["인구수(여)"]),
                    });

                }
                this.DataContext = Population;
            }

        }
        public GraphWindow(double coordy, string coordx) : this()
        {
        }
    }
}
