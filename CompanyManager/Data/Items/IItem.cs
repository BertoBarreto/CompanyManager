/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 7:09:28 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager.Data.Items
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public interface IItem
    {
        int Id { get; }
        string ItemName { get; }
        double Amount { get; }

        void RemoveAmount(double amount);
        void AddAmount(double amount);
        void EditItem(string name);

    }
}
