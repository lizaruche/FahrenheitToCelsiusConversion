using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Реструктуризация" можно использовать для одновременного изменения имени класса "Service" в коде, SVC-файле и файле конфигурации.
public class ConversionService : IService
{
    public double CelsiusToFahrenheit(double celsiusDegree)
    {
        return 9.0 / 5 * (celsiusDegree + 32);
    }

    public double FahrenheitToCelsius(double fahrenheitDegree)
    {
        return 5.0 / 9 * (fahrenheitDegree - 32);
    }
}
