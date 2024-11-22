
## Software Requirements

Make sure you have the following software installed on your system:

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)


# APITestProject

## Project Structure

- **CodingExercise**: Contains the coding exercise for the interviewee.
- **CodingExercise.Tests**: Contains the unit tests for the coding exercise.

- **Controllers**: Contains the API controllers.
- **Models**: Contains the data models.
- **Repositories**: Contains the repository classes for data access.
- **Tests**: Contains the unit tests for the API.

## Exercise

### Task 1: Complete the Coding Exercise

In the `CodingExercise` project, there is a `StringOperations` class with a `CountCharacterOccurrences` method. Your task is to implement this method to count the occurrences of each character in a given string. The input string must be at least 10 characters long and cannot be empty.

### Task 2: Write Unit Test Cases for the Coding Exercise

After implementing the `CountCharacterOccurrences` method, write the following unit test cases in the `CodingExercise.Tests` project:

1. **CountCharacterOccurrences_ReturnsCorrectCounts**: Ensure that the `CountCharacterOccurrences` method correctly counts the occurrences of each character in a non-empty string.
2. **CountCharacterOccurrences_EmptyString_ThrowsException**: Ensure that the `CountCharacterOccurrences` method throws an exception for an empty string.
3. **CountCharacterOccurrences_VariousInputs_ReturnsCorrectCounts**: Ensure that the `CountCharacterOccurrences` method correctly counts the occurrences for various strings.

### Task 3: Fix the Compile-Time Error

There is a deliberate compile-time error in one of the unit test cases in the `APITestProject.Tests` project. Your task is to identify and fix the error.

### Task 4: Implement the Unit Test Cases for the API

Implement the following unit test cases based on the method names provided in the `APITestProject.Tests` project:

1. **GetProducts_WhenEmpty_ReturnsEmptyList**: Ensure that the `GetProducts` method returns an empty list when there are no products.
2. **GetProduct_ReturnsNotFoundResult**: Ensure that the `GetProduct` method returns a `NotFoundResult` when the product does not exist.
3. **GetProduct_ReturnsProduct**: Ensure that the `GetProduct` method returns the correct product when it exists.
4. **PostProduct_ReturnsCreatedAtActionResult**: Ensure that the `PostProduct` method returns a `CreatedAtActionResult` when a product is successfully created.
5. **PutProduct_ReturnsNoContentResult**: Ensure that the `PutProduct` method returns a `NoContentResult` when a product is successfully updated.
6. **PutProduct_ReturnsNotFoundResult**: Ensure that the `PutProduct` method returns a `NotFoundResult` when the product to be updated does not exist.
7. **DeleteProduct_ReturnsNoContentResult**: Ensure that the `DeleteProduct` method returns a `NoContentResult` when a product is successfully deleted.
8. **DeleteProduct_ReturnsNotFoundResult**: Ensure that the `DeleteProduct` method returns a `NotFoundResult` when the product to be deleted does not exist.


