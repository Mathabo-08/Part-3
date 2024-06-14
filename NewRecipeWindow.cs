
using System.Windows;

namespace recipeApp_WPF
{
    internal class NewRecipeWindow
    {


        internal bool? ShowDialog()
        {
            // Create an instance of the new window for entering recipe details
            NewRecipeWindow newRecipeWindow = new NewRecipeWindow();

            // Display the new window as a dialog
            bool? result = newRecipeWindow.ShowDialog();

            // Return the result of the dialog (whether the user clicked OK or Cancel)
            return result;
        }

        // Define a public property to hold the newly added recipe
        public Recipe NewRecipe { get; private set; }
        
    }
}