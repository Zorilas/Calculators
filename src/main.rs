use std::io;

fn main() {
    let mut input = String::new();

    println!("Please pick the first number: ");
    io::stdin().read_line(&mut input).expect("Failed to read input");
    let first_number: i32 = input.trim().parse().expect("Please enter a number");
    input.clear();

    println!("Please pick the second number: ");
    io::stdin().read_line(&mut input).expect("Failed to read input");
    let second_number: i32 = input.trim().parse().expect("Please enter a number");

    let result = first_number + second_number;
    println!("Result: {}", result);
}
