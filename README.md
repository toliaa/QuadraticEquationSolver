# Quadratic Equation Solver

This project is a simple Windows Forms application that solves quadratic equations of the form `ax^2 + bx + c = 0`. It is implemented in C# using Visual Studio 2022.

## Features

- Calculates the roots of a quadratic equation.
- Handles cases with two real roots, one real root, and no real roots.
- Provides error messages for invalid inputs.

## Requirements

- Visual Studio 2022
- .NET Framework

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Prerequisites

Ensure you have Visual Studio 2022 installed with the .NET desktop development workload.

### Installation

1. Clone the repository to your local machine using:
    ```sh
    git clone https://github.com/toliaa/QuadraticEquationSolver.git
    ```

2. Open the solution file `QuadraticEquationSolver.sln` in Visual Studio 2022.

3. Build the project by selecting `Build > Build Solution` or by pressing `Ctrl+Shift+B`.

4. Run the project by selecting `Debug > Start Debugging` or by pressing `F5`.

## Usage

1. Enter the values of coefficients `a`, `b`, and `c` in the respective text boxes.
2. Click the "Solve" button to calculate the roots of the quadratic equation.
3. The results will be displayed below the button. If the equation has no real roots, an appropriate message will be shown.

### Example Inputs and Outputs

- **Example with two real roots**:
  - Input: `a = 1`, `b = -3`, `c = 2`
  - Output: `Root 1: 2, Root 2: 1`
  
- **Example with one real root (double root)**:
  - Input: `a = 1`, `b = -2`, `c = 1`
  - Output: `Root 1: 1, Root 2: 1`
  
- **Example with no real roots**:
  - Input: `a = 1`, `b = 1`, `c = 1`
  - Output: `No real roots`
  
- **Example with invalid input**:
  - Input: `a = a`, `b = b`, `c = c`
  - Output: `Please enter valid numeric values.`

## Project Structure

- **QuadraticEquationForm.cs**: Contains the main logic for handling user input and displaying results.
- **QuadraticEquationForm.Designer.cs**: Contains the auto-generated code for the UI components.
- **QuadraticSolver.cs**: Contains the logic for solving the quadratic equation.

## Error Handling

- **FormatException**: Caught when the user inputs non-numeric values. Displays a message box prompting the user to enter valid numeric values.
- **Exception**: Catches all other exceptions and displays a generic error message.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- The project was developed using Visual Studio 2022.
- The quadratic equation solver logic is based on standard mathematical formulas.

