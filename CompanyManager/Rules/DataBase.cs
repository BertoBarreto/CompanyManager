/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 9:46:26 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace CompanyManager.Rules
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public class DataBase
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CompanyManager.Properties.Settings.CompanyManagerDBConnectionString1"].ConnectionString;

    }
}
