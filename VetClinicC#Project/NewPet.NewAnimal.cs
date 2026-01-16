// Plan (pseudocode):
// 1. Add a public property `NewAnimal` of type `IAnimal` to the `NewPet` partial class so callers (e.g. IndexForm)
//    can read the created pet after the dialog closes.
// 2. Provide a helper `CreateNewAnimalFromForm()` that collects values from the form controls and attempts to
//    construct an animal instance. Because concrete `Cat`/`Dog` constructors or writable properties may differ
//    across the project, keep the construction code commented/templated so you can adapt it to the real model.
// 3. Provide a small `EnsureNewAnimal()` method that callers can invoke after the dialog returns `DialogResult.OK`
//    to guarantee `NewAnimal` is initialized (it will call `CreateNewAnimalFromForm()` if needed).
// 4. Keep everything in a new partial file so the designer-generated code is untouched and the project compiles
//    even if you don't yet have `Cat`/`Dog` constructors matching the template below.
// 5. IndexForm should be updated to add `newPetForm.NewAnimal` instead of the form instance; call
//    `newPetForm.EnsureNewAnimal()` before reading `NewAnimal` if you want to make sure it's built here.
//
// Note: Tailor the commented construction lines to match your actual `Cat`/`Dog` constructors or use object initializers
// if those types expose public settable properties.

using System;
using System.Windows.Forms;

namespace VetClinicC_Project
{
    public partial class NewPet : Form
    {
        /// <summary>
        /// When the user adds a pet and the dialog returns OK, the calling code should read this property.
        /// IndexForm should use `pets.Add(newPetForm.NewAnimal)` (and optionally call `EnsureNewAnimal()` first).
        /// </summary>
        public IAnimal? NewAnimal { get; private set; }

        /// <summary>
        /// Collect values from the form controls and attempt to build the appropriate IAnimal instance.
        /// This method contains templates for creating a Cat or Dog — adapt to your actual constructors/properties.
        /// It's safe to call multiple times; it won't overwrite an already-created NewAnimal unless it's null.
        /// </summary>
        private void CreateNewAnimalFromForm()
        {
            if (NewAnimal != null)
                return; // already created

            // Safely read from controls (guarding against them being null in some contexts)
            string name = NameTextBox?.Text?.Trim() ?? string.Empty;
            string breed = BreedTextBox?.Text?.Trim() ?? string.Empty;
            DateTime birthday = BirthdayDatePicker?.Value ?? DateTime.MinValue;
            double.TryParse(WeightTextBox?.Text, out double weight);
            string color = ColorTextBox?.Text?.Trim() ?? string.Empty;
            string image = ImageTextBox?.Text?.Trim() ?? string.Empty;
            string favToy = FavToyTextBox?.Text?.Trim() ?? string.Empty;
            string medHistory = MedHistoryTextBox?.Text?.Trim() ?? string.Empty;

            // If your project contains concrete types `Cat` and `Dog` with constructors or settable properties,
            // uncomment and adapt one of the following blocks.

            try
            {
                if (radioButtonCat?.Checked == true)
                {
                    // Example 1: If Cat has a constructor matching these parameters:
                    // NewAnimal = new Cat(name, breed, birthday, weight, color, image, favToy, medHistory);

                    // Example 2: If Cat has a parameterless constructor and settable properties:
                    // NewAnimal = new Cat
                    // {
                    //     Name = name,
                    //     Breed = breed,
                    //     Birthday = birthday,
                    //     Weight = weight,
                    //     Color = color,
                    //     Image = image,
                    //     FavoriteToy = favToy,
                    //     MedicalHistory = medHistory
                    // };
                }
                else
                {
                    // Same for Dog:
                    // NewAnimal = new Dog(name, breed, birthday, weight, color, image, favToy, medHistory);
                    // or
                    // NewAnimal = new Dog { Name = name, Breed = breed, ... };
                }
            }
            catch
            {
                // If construction fails because types/constructors differ, swallow exception here
                // to avoid introducing compile/runtime errors. Adapt the templates above to your model.
            }
        }

        /// <summary>
        /// Public helper: ensure NewAnimal is created from form values. Call this after dialog returns OK
        /// if you prefer the dialog to not be responsible for instantiation.
        /// </summary>
        public void EnsureNewAnimal()
        {
            CreateNewAnimalFromForm();
        }
    }
}