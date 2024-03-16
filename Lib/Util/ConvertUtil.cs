using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Util
{
    public class ConvertUtil
    {
        public static T ToObject<T>(object sourceObj)
        {
            var resultObj = (T)Activator.CreateInstance(typeof(T));

            // 取得指定物件所有屬性
            var properties = resultObj.GetType().GetProperties();

            foreach (var property in properties)
            {
                // 來源物件屬性
                var objectInfo = sourceObj.GetType().GetProperty(property.Name);

                // 來源物件有該屬性且型別一致，將資料存入指定物件的屬性
                if (property.CanWrite && objectInfo != null && property.PropertyType == objectInfo.PropertyType)
                {
                    property.SetValue(resultObj, objectInfo.GetValue(sourceObj));
                }
            }

            return resultObj;
        }
    }
}
