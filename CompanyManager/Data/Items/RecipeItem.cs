/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 7:12:35 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager.Data.Items
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public class RecipeItem
    {
        #region PROPERTIES
        private int itemId;

        public int ItemId
        {
            get { return itemId; }
        }

        private double amount;

        public double Amount
        {
            get { return amount; }
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Basic Class constructor that gets user input and creates a new recipeItem for a finalItem recipe
        /// </summary>
        public RecipeItem()
        {
            itemId = DataCheck.TryReadPrimaryItemId("Item id: ");

            amount = DataCheck.TryReadDouble("Amount: ");

        }

        #endregion

        #region METHODS

        public override string ToString()
        {
            PrimaryStock.GetItem(itemId);
            return string.Format($"\nQuantity: {amount}");
        }

        #endregion

    }
}
