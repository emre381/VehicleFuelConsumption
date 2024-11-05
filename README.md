


# Vehicle Fuel Consumption Calculator

This project is a **Vehicle Fuel Consumption Calculator** built using **.NET MAUI**. The application allows users to select a car brand, model, and year, then enter the distance they wish to travel in both city and highway conditions. Based on this input, the app calculates the fuel consumption for city and highway driving.

## Features

- Select car **brand**, **model**, and **year** from predefined lists.
- Input distance in kilometers for **city** and **highway** driving.
- Calculates and displays fuel consumption for city and highway driving in liters.
- Simple and user-friendly interface.
- Expandable car list, supporting various brands such as **Toyota**, **Honda**, **BMW**, **Ford**, **Mercedes**, **Audi**, **Hyundai**, and **Kia**.

## Prerequisites

- **.NET 6 SDK or newer**.
- **Visual Studio 2022** (or newer) with .NET MAUI workload installed.

## Installation and Setup

Follow these steps to set up the project:

1. Clone the repository:
   ```bash
   git clone https://github.com/emre381/VehicleFuelConsumption.git
   ```

2. Navigate to the project directory:
   ```bash
   cd vehicle-fuel-calculator
   ```

3. Open the project in Visual Studio 2022 or your preferred IDE.

4. Ensure you have the **.NET MAUI workload** installed. To install it via the command line, run:
   ```bash
   dotnet workload install maui
   ```

5. Build the project:
   ```bash
   dotnet build
   ```

6. Run the application on your preferred platform (Windows, Android, iOS, or macOS):
   ```bash
   dotnet run
   ```

## Usage

1. **Select Vehicle**: Choose the **brand**, **model**, and **year** of the vehicle from the available options.
2. **Input Kilometers**: Enter the number of kilometers you plan to drive in the city and on the highway.
3. **Calculate**: Press the **Calculate** button, and the app will display the fuel consumption for both city and highway driving.

## Example

1. Select **Toyota** as the brand, **Corolla** as the model, and **2020** as the year.
2. Input **50 km** for city driving and **100 km** for highway driving.
3. The app will calculate and display the fuel consumption in liters for both driving conditions.

## Adding New Vehicles

You can easily add new vehicles by modifying the `araclar` list in the `MainPage.xaml.cs` file:

```csharp
List<Arac> araclar = new List<Arac>
{
    new Arac { Marka = "Toyota", Model = "Corolla", Yil = 2020, SehirIciTuketim = 7.5, SehirDisiTuketim = 5.0 },
    new Arac { Marka = "Honda", Model = "Civic", Yil = 2019, SehirIciTuketim = 8.0, SehirDisiTuketim = 5.5 },
    // Add more vehicles here
};
```

## Technologies Used

- **.NET MAUI**: Cross-platform app development framework.
- **C#**: Programming language.
- **XAML**: For UI design.

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add some feature'`).
5. Push to the branch (`git push origin feature-branch`).
6. Open a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more information.

