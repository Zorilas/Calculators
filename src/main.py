import math

def normalcalc():
    while True:
        try:
            firstNumber = int(input("Please select the first number: "))
            secondNumber = int(input("Please select the second number: "))
            selection = input("Select an operation (/, +, *, -) or type 'exit' to quit: ")

            if selection.lower() == "exit":
                print("Calculator closed.")
                break

            if selection == "/":
                if secondNumber == 0:
                    print("Error: Division by zero is not allowed!")
                else:
                    print(f"Result: {firstNumber / secondNumber}")

            elif selection == "*":
                print(f"Result: {firstNumber * secondNumber}")

            elif selection == "+":
                print(f"Result: {firstNumber + secondNumber}")

            elif selection == "-":
                print(f"Result: {firstNumber - secondNumber}")

            else:
                print("Invalid selection! Please choose one of: /, +, *, -")

        except ValueError:
            print("Error: Please enter valid numbers!")

def calc():
    Pi = math.pi
    E = math.e
    selection = input("Type 'Pi' for π or 'E' for Euler's number: ").lower()

    if selection == "pi":
        print(f"Pi: {Pi}")
    elif selection == "e":
        print(f"Euler's number: {E}")
    else:
        print("Invalid input! Please enter 'Pi' or 'E'.")


user_selection = input("Choose mode: 'Normal Calculator' or 'Calculator': ").lower()

if user_selection == "normal calculator":
    normalcalc()
elif user_selection == "calculator":
    calc()
else:
    print("Invalid selection! Please enter 'Normal Calculator' or 'Calculator'.")
