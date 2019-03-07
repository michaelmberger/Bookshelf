# Bookshelf
Demo application to demonstrate CRUD operations

The application is a basic bookshelf. It does what you would expect a bookshelf to do: Add a book(C), read the titles of the bookshelf(R), and delete a book(D). In later stages, updating databa about a book will be added. 

Structure
Each application is first a command line application. This is to keep things simple and provide an easily testable starting point. Each stage is a new application but of course there will be some code reuse.

Design philosophy
I will be using object oriented principles wherever practical although this will vary where the language does not have these features or lend itself to this paradigm.

Stage 1: The application stores the book list in an internal list.
Stage 2: The application writes the list to a file and modifies the file as appropriate
Stage 3: The application writes the list to a database. In this case, I'm using PostGre
Stage 4: The application exposes a web JSON REST api to apply the CRUD operations to the list of books.
Stage 5: The application, when given a valid ISBN, requsts book information from a provider and returns it.
Stage 6: If possible, deploy the application to a cloud provider.

At this point, all backend tech will have been excersized so I will work on building a font end to the API. 

Stage 1: The application will consume the api, showing formatted text results.
Stage 2: The application applies filters to the results
Stage 3: The application queries alternative apis for reviews and maybe suggestions.
