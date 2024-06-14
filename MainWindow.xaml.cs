using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace recipeApp_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Declare variables
        public List<string> Ingredients { get; set; }
        public List<string> recipeName { get; set; }
        public string FoodGroup { get; set; }
        public Ingredients ingredients;
        private Steps steps;
        private bool printSelectedRecipe;


        private void EnterNewRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Prompt the user to enter the name of the recipe
            string recipeName = PromptUser("Enter the name of the recipe:");

            // Prompt the user to enter the number of ingredients
            int ingredientCount = PromptUserInt("Enter the number of ingredients:");

            // Create a list to store the ingredients
            List<Ingredients> ingredients = new List<Ingredients>();

            // Prompt the user to enter the details for each ingredient
            for (int i = 0; i < ingredientCount; i++)
            {
                string ingredientName = PromptUser($"Enter the name of ingredient #{i + 1}:");
                double quantity = PromptUserDouble($"Enter the quantity of ingredient #{i + 1}:");
                string unit = PromptUser($"Enter the unit of measurement for ingredient #{i + 1}:");

                // Create a new Ingredient object and add it to the list
                Ingredients ingredient = new Ingredients(ingredientName, quantity, unit);
                ingredients.Add(ingredient);
            }

            // Prompt the user to enter the number of steps
            int stepCount = PromptUserInt("Enter the number of steps:");

            // Create a list to store the steps
            List<string> steps = new List<string>();

            // Prompt the user to enter the description for each step
            for (int i = 0; i < stepCount; i++)
            {
                string stepDescription = PromptUser($"Enter the description for step #{i + 1}:");
                steps.Add(stepDescription);
            }

            // TODO: Save the recipe details or perform any other necessary actions

            // Display a success message to the user
            MessageBox.Show("Recipe details entered successfully!");
        }

        // Helper method to prompt the user for input and return the entered value as a string
        private string PromptUser(string message)
        {
            // TODO: Implement the logic to display a prompt and get user input
            // For example, you can use a MessageBox or a custom input dialog

            return ""; // Placeholder return value
        }

        // Helper method to prompt the user for input and return the entered value as an integer
        private int PromptUserInt(string message)
        {
            // TODO: Implement the logic to display a prompt and get user input
            // For example, you can use a MessageBox or a custom input dialog

            return 0; // Placeholder return value
        }

        // Helper method to prompt the user for input and return the entered value as a double
        private double PromptUserDouble(string message)
        {
            // TODO: Implement the logic to display a prompt and get user input
            // For example, you can use a MessageBox or a custom input dialog

            return 0.0; // Placeholder return value
        }

        private void SelectRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Add logic to handle selecting a recipe
        }

        private void Filter(object sender, RoutedEventArgs e)
        {
            // Add logic to handle filtering recipes
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            // Add logic to handle exiting the application
            Application.Current.Shutdown();
        }
    }
}