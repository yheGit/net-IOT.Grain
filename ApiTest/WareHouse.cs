using Net66.Comm;
using Net66.Entity.IO_Model;
using Net66.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest
{
    class WareHouseTest
    {
        private static string httpUrl = @"http://200.200.3.230:8012/api";
        public static string AddWareHouse()
        {
            #region 
            var _entity = new IWareHouse();
            _entity.IsActive = 1;
            _entity.Location = "深证市宝安区";
            _entity.Name = "E楼房仓";
            _entity.Number = "L5";
            _entity.Type = 1;
            _entity.UserId = "0";

            #endregion
            var jsonStr = JsonConvertHelper.SerializeObject(_entity);

            var apiUrl = httpUrl + @"/Grain/Add";
            string data = jsonStr;
            //var moaHttp = string.Format(httpUrl, accessToken);
            var reJson = WebHelper.Post(apiUrl, data);

            return string.Join(jsonStr, "+++") + string.Join(reJson, "+++");
        }

        public static string UpdateWareHouse()
        {
            #region 
            var _entity = new WareHouse();
            _entity.ID = 4;
            _entity.IsActive = 1;
            _entity.Location = "深证市宝安区";
            _entity.Name = "DD楼房仓";
            _entity.Number = "L44";
            _entity.Type = 1;
            _entity.UserId = "0";

            #endregion
            var jsonStr = JsonConvertHelper.SerializeObject(_entity);

            var apiUrl = httpUrl + @"/Grain/Modify";
            string data = jsonStr;
            //var moaHttp = string.Format(httpUrl, accessToken);
            var reJson = WebHelper.Post(apiUrl, data);

            return string.Join(jsonStr, "+++") + string.Join(reJson, "+++");
        }

        public static string DeleteWareHouse()
        {
            #region 
            var list = new List<WareHouse>();
            var _entity = new WareHouse();
            _entity.ID = 4;
            _entity.IsActive = 1;
            _entity.Location = "深证市宝安区";
            _entity.Name = "DD楼房仓";
            _entity.Number = "L44";
            _entity.Type = 1;
            _entity.UserId = "0";
            list.Add(_entity);

            #endregion
            var jsonStr = JsonConvertHelper.SerializeObject(list);

            var apiUrl = httpUrl + @"/Grain/Delete";
            string data = jsonStr;
            //var moaHttp = string.Format(httpUrl, accessToken);
            var reJson = WebHelper.Post(apiUrl, data);

            return string.Join(jsonStr, "+++") + string.Join(reJson, "+++");
        }

        public static string AddFloor()
        {
            #region 
            var list = new List<Floor>();
            var _entity = new Floor();
            _entity.IsActive = 1;
            _entity.Location = "深证市宝安区";
            _entity.Number = "F5";
            _entity.UserId = 0;
            _entity.WH_Number = "L2";
            list.Add(_entity);
            #endregion
            var jsonStr = JsonConvertHelper.SerializeObject(list);

            var apiUrl = httpUrl + @"/Floor/Add";
            string data = jsonStr;
            //var moaHttp = string.Format(httpUrl, accessToken);
            var reJson = WebHelper.Post(apiUrl, data);

            return string.Join(jsonStr, "+++") + string.Join(reJson, "+++");
        }


        public static string AddGranary()
        {
            #region 
            var list = new List<Granary>();
            var _entity = new Granary();
            _entity.IsActive = 1;
            _entity.Location = "深证市宝安区";
            _entity.Number = "L2-F2-A";
            _entity.UserId = 0;
            //_entity.F_Number = "L2-F2";
            
            list.Add(_entity);
            #endregion
            var jsonStr = JsonConvertHelper.SerializeObject(list);

            var apiUrl = httpUrl + @"/Floor/Add";
            string data = jsonStr;
            //var moaHttp = string.Format(httpUrl, accessToken);
            var reJson = WebHelper.Post(apiUrl, data);

            return string.Join(jsonStr, "+++") + string.Join(reJson, "+++");
        }



        public static string AddHeap()
        {
            #region 
            var list = new List<Heap>();
            var _entity = new Heap();
            _entity.IsActive = 1;
            _entity.Location = "深证市宝安区L2-F2-A-1";
            _entity.Number = "L2-F2-A-1";
            _entity.UserId = 0;
            _entity.G_Number = "L1-F2-A";
            

            list.Add(_entity);
            #endregion
            var jsonStr = JsonConvertHelper.SerializeObject(list);

            var apiUrl = httpUrl + @"/Heap/Add";
            string data = jsonStr;
            //var moaHttp = string.Format(httpUrl, accessToken);
            var reJson = WebHelper.Post(apiUrl, data);

            return string.Join(jsonStr, "+++") + string.Join(reJson, "+++");
        }


    }
}
