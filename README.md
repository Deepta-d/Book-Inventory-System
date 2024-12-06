# Book-Inventory-System

This project is a Book Inventory Management System that allows users to manage a collection of books through a database-driven application. The system provides functionalities to add new books, filter the inventory, and export data in CSV or JSON formats.

Features
Schema Design:

A relational database table named Inventory with the following columns:
EntryID: Unique identifier for each book (Primary Key).
Title: The title of the book.
Author: The author(s) of the book.
Genre: The genre of the book.
PublicationDate: The publication date of the book.
ISBN: The ISBN number of the book.
Database Setup:

The database is implemented using a relational database management system (RDBMS) such as MySQL, PostgreSQL, or SQLite.
SQL scripts are provided to set up the database schema (schema.sql).
Add New Books:

A form to add new books to the inventory with input validation (e.g., valid ISBN format, required fields).
Filter Books:

A filtering interface to search books by title, author, or genre.
Filtered results are displayed in a table or list format.
Export Data:

Users can export the inventory in CSV or JSON formats.
Exported files can be downloaded via the user interface.
User Interface:

Responsive UI components:
Add Book Form: Input form for adding new books.
Filter Form: Controls for filtering the inventory.
Books List: Table or list for displaying books.
Export Button: Button to trigger data export functionality.
Clean and user-friendly design.
