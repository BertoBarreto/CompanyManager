/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 4/23/2021 10:23:32 AM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public interface Iitem
    {
        int Id { get; set; }
        string ItemName { get; set; }
        double Amount { get; }

        void RemoveAmount(double amount);
        void AddAmount(double amount);
    }
}
