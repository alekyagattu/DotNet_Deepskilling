import React, { useState } from 'react';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';

function App() {
  const [show, setShow] = useState('books');

  let content;
  // Conditional rendering using if-else
  if (show === 'books') {
    content = <BookDetails />;
  } else if (show === 'blogs') {
    content = <BlogDetails />;
  } else if (show === 'courses') {
    content = <CourseDetails />;
  } else {
    content = <p>Select a category</p>;
  }

  return (
    <div style={{ textAlign: 'center', padding: '20px', fontFamily: 'Arial' }}>
      <h1>Blogger App</h1>

      <div style={{ marginBottom: '20px' }}>
        <button onClick={() => setShow('books')}>Show Books</button>{' '}
        <button onClick={() => setShow('blogs')}>Show Blogs</button>{' '}
        <button onClick={() => setShow('courses')}>Show Courses</button>
      </div>

      {/* Conditional Rendering using element variable */}
      {content}

      {/* Conditional Rendering using ternary */}
      <p style={{ marginTop: '40px', fontStyle: 'italic' }}>
        Currently viewing: {show === 'books'
          ? "Books"
          : show === 'blogs'
          ? "Blogs"
          : show === 'courses'
          ? "Courses"
          : "None"}
      </p>
    </div>
  );
}

export default App;

