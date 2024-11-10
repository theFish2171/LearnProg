use std::io;

fn main() {
    println!("Guess a number!");
    println!("Please input your guess.");
    let mut guess = String::new();

    io::stdin()
        .read_line(&mut guess)
        .expect("Failed to read line");
    println!("You guested: {}", guess);

    // let mut x = 5;
    // let mut y = 10;

    // println!("x = {x} and y + 2 = {}", y + 2);

    // x = 8;
    // y = 15;

    // println!("x = {x} and y + 2 = {}", y + 2);
}
