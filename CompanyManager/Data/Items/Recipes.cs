/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 7:14:18 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using CompanyManager.Rules;
using System.IO;

namespace CompanyManager.Data.Items
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public class Recipes
    {
        #region PROPERTIES
        private static Dictionary<int, List<RecipeItem>> recipes = new Dictionary<int, List<RecipeItem>>();
        #endregion


        #region METHODS
        public static void save()
        {
            CompanyManager.FileManager.SaveRecipe(recipes);
        }
        #region SETTERS
        /// <summary>
        /// This method allows to create and add a recipe item to the recipes Dictionary asking for all the requirements
        /// </summary>
        /// <param name="id">Final Item id</param>
        public static void AddRecipe(int id)
        {
            if (recipes.ContainsKey(id))
                return;
            char decision;
            List<RecipeItem> recipeItems = new List<RecipeItem>();
            Console.WriteLine("*********Recipe items*********");
            do
            {

                RecipeItem item = new RecipeItem();
                recipeItems.Add(item);

                Console.WriteLine("Do you wish to add more?[Y/N]");

                decision = Console.ReadLine()[0];

            } while (char.ToLower(decision) != 'n');
            recipes.Add(id, recipeItems);
        }

        /// <summary>
        /// This method allows to add a recipe item to the recipes dictionary adding a item to the recipe item list, and in case the final item already has a recipe it adds it to the list
        /// </summary>
        /// <param name="i">Item to add</param>
        /// <param name="id">Final item id</param>
        public static void AddRecipe(RecipeItem i, int id)
        {
            if (!recipes.ContainsKey(id))
                recipes.Add(id, new List<RecipeItem>());

            if (recipes[id].Contains(i)) return;


            recipes[id].Add(i);
        }
        #endregion

        #region GETTERS
        /// <summary>
        /// This method allows to Get items recipes
        /// </summary>
        public static void GetRecipes()
        {
 
            foreach (KeyValuePair<int, List<RecipeItem>> pair in recipes)
            {
                FinalStock.GetItem(pair.Key);
                    
                Console.WriteLine("***************RECIPE****************");

                foreach (RecipeItem i in pair.Value)
                {
                    PrimaryStock.GetItem(i.PrimaryItem);
                    Console.WriteLine($"Quantity: {i.Amount}");
                }
                Console.WriteLine("*************************************");
            }

        }

        /// <summary>
        /// This method allows to Get item recipe
        /// </summary>
        /// <param name="id">Final item Id</param>
        public static void GetRecipe(int id)
        {
            if (recipes.ContainsKey(id))
            {
                foreach (RecipeItem r in recipes[id])
                {
                    Console.WriteLine(r);
                }
            }
            else
                DataRules.ErrorMsg("There isnt any recipe for that FinalItem");

        }

        /// <summary>
        /// This method allows to check if a item is already in a recipe
        /// </summary>
        /// <param name="i">Recipe item to check</param>
        /// <returns>bool</returns>
        public static bool Contains(RecipeItem i)
        {
            if (recipes.ContainsKey(i.FinalItem))
            {
                if (recipes[i.FinalItem].Contains(i))
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        /// <summary>
        /// This method allows to list to the user all the final items that can be made
        /// </summary>
        public static void RecipesCanBeMade()
        {
            bool canDo = true;
            
            foreach (KeyValuePair<int, List<RecipeItem>> pair in recipes)
            {
                ArrayList results = new ArrayList();

                foreach (RecipeItem i in pair.Value)
                {
                    if (!PrimaryStock.HasEnough(i.Amount, i.PrimaryItem))
                        canDo = false;
                    else
                    {
                        double stock = PrimaryStock.GetStock(i.PrimaryItem);
                        double aux =  stock/ i.Amount;
                        results.Add(aux);
                    }
                    
                }
                if (canDo)
                {
                    
                    int lower = Convert.ToInt32(results[0]);

                    FinalStock.GetItem(pair.Key);
                    for (int i = 0; i < results.Count; i++)
                    {
                        int aux = Convert.ToInt32(results[i]);
                        if (aux < lower)
                            lower = aux;
                    }
                    Console.WriteLine($"Can make: {lower} {FinalStock.GetName(pair.Key)}");
                }

                canDo = true;
                

            }
            
            
        }
        /// <summary>
        /// This method allows to check if a recipe can be made
        /// </summary>
        /// <param name="id">Final item id</param>
        public static void CanBeMade(int id)
        {

            bool canDo = true;
            ArrayList results = new ArrayList();
            if (recipes.ContainsKey(id))
            {
                foreach (RecipeItem i in recipes[id])
                {
                    if (!PrimaryStock.HasEnough(i.Amount, i.PrimaryItem))
                        canDo = false;
                    else
                    {
                        double stock = PrimaryStock.GetStock(i.PrimaryItem);
                        double aux = stock / i.Amount;
                        results.Add(aux);
                    }
                }
                if (canDo)
                {
                    FinalStock.GetItem(id);
                    Console.WriteLine("There is enough stock to make this item");
                    int lower = Convert.ToInt32(results[0]);
                    for (int i = 0; i < results.Count; i++)
                    {
                        int aux = Convert.ToInt32(results[i]);
                        if (aux < lower)
                            lower = aux;
                    }
                    Console.WriteLine($"Can make: {lower} {FinalStock.GetName(id)}");
                    return;
                }
                else
                {
                    Console.WriteLine("There isn't enough stock to make this item");
                    return;
                }

            }else
                DataRules.ErrorMsg("There isnt any recipe for that FinalItem");
        


        }
        #endregion
        /// <summary>
        /// This method allows so save Recipe data
        /// </summary>
        public static void SaveRecipe()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CompanyManager\Data\Items";
            try
            {
                StringBuilder sb = new StringBuilder();

                foreach (KeyValuePair<int, List<RecipeItem>> pair in recipes)
                {

                    foreach (RecipeItem item in pair.Value)
                    {
                        sb.AppendFormat($"{item.Id},");

                    }
                    sb.AppendFormat($"{pair.Key},");
                    sb.Remove(sb.Length - 1, 1);
                    sb.AppendLine();
                }


                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                File.WriteAllText(path + @"\Recipes.csv", sb.ToString(), Encoding.UTF8);// encoding.utf8 allows to have special characters

            }
            catch
            {
                DataRules.ErrorMsg("Error saving in the data file");
            }
        }
        #endregion

    }
}
