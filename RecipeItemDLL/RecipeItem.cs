using System;
using DataCheckDLL;
using PrimaryStockDLL;

namespace RecipeItemDLL
{
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
