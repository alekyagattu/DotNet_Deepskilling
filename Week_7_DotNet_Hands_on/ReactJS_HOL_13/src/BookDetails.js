import React from 'react';

const books = [
  { id: 1, title: "React Basics", author: "Alekya" },
  { id: 2, title: "Learning JSX", author: "Ammu" },
  { id: 3, title: "React Patterns", author: "Pranu" }
];

const BookDetails = () => (
  <div>
    <h2>Book Details</h2>
    <ul>
      {books.map(book => (
        <li key={book.id}>
          <strong>{book.title}</strong> by {book.author}
        </li>
      ))}
    </ul>
  </div>
);

export default BookDetails;
