/* Task Description */
/*
 *  Create a module for working with books
 *  The module must provide the following functionalities:
 *  Add a new book to category
 *  Each book has unique title, author and ISBN
 *  It must return the newly created book with assigned ID
 *  If the category is missing, it must be automatically created
 *  List all books
 *  Books are sorted by ID
 *  This can be done by author, by category or all
 *  List all categories
 *  Categories are sorted by ID
 *  Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *  When adding a book/category, the ID is generated automatically
 *  Add validation everywhere, where possible
 *  Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *  Author is any non-empty string
 *  Unique params are Book title and Book ISBN
 *  Book ISBN is an unique code that contains either 10 or 13 digits
 *  If something is not valid - throw Error
 */
function solve() {

    var library = (function () {

        var books = [],
            categories = [];

        function listBooks() {

            var prop,
                authorToCheck,
                categoryToCheck,
                result = [];

            books = books.sort(sortBooks);

            function sortBooks(first, second) {

                return first.id - second.id;
            }

            if (arguments.length === 0) {
                return books;
            } else if (arguments.length === 1) {

                for (prop in arguments[0]) {

                    result = filterBooks(books, prop, arguments[0][prop]);
                }
            }

            function filterBooks(booksArr, key, value) {

                return booksArr.filter(function (book) {
                    return book[key] === value;
                });
            }

            return result;
        }

        function addBook(book) {

            var checkDuplicatingBooks,
                checkIncorrectLength;

            checkIncorrectLength = function (value, min, max) {
                if (value < min || value > max) {
                    return true;
                }
            };

            checkDuplicatingBooks = books.some(function (bookInArr) {
                return bookInArr.title === book.title || bookInArr.isbn === book.isbn;
            });

            if (checkIncorrectLength(book.title.length, 2, 100)) {
                throw {message: 'Book title length is too short or too long'};
            }

            if (!book.hasOwnProperty('category')) {
                book.category = 'Other';
            }

            if (checkIncorrectLength(book.category.length, 2, 100)) {
                throw  {message: 'Book category length is too short or too long'};
            }

            if (!book.author) {
                throw {message: 'Book author is missing'};
            }

            if (checkIncorrectLength(book.isbn.length, 10, 13)) {
                throw {message: 'Book ISBN length is too short or too long'};
            }

            if (checkDuplicatingBooks) {
                throw {message: 'Duplicating book title or book ISBN'};
            }

            book.ID = books.length + 1;

            books.push(book);

            return book;
        }

        function listCategories() {

            books.forEach(function (book) {

                var categoryToAdd = book.category;

                if (!categories.some(function (label) {
                        return label === categoryToAdd;
                    })) {
                    categories.push(book.category);
                }
            });

            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());

    return library;
}
module.exports = solve;