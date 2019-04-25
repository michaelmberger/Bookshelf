use std::io;

fn main() {
    let mut choice: u8 = 0;
    while choice != 4 {
        choice = choose_option();
        match choice {
            1 => {add_book()},
            2 => {println!("No implemented yet");},
            3 => {println!("No implemented yet");},
            4 => {continue;}
            _ => {println!("You did not enter a valid option");continue;}
        }

    }
    
}
fn choose_option() -> u8 {
    println!("Choose from the following options:");
    println!("1. Enter a new book");
    println!("2. List all books");
    println!("3. Delete a book");
    println!("4. Quit");
    let mut input = String::new();
    io::stdin().read_line(&mut input).expect("Failed to read line");
    let option: u8 = match input.trim().parse() {
        Ok(num) => num,
        Err(_) => {0}
    };
    option
}
fn add_book() {

}
