import React from 'react';

const blogs = [
  { id: 1, title: "Why React is Popular", views: 1500 },
  { id: 2, title: "React vs Angular", views: 1200 },
  { id: 3, title: "React 2024 Features", views: 2100 }
];

const BlogDetails = () => (
  <div>
    <h2>Blog Details</h2>
    <ul>
      {blogs.map(blog => (
        <li key={blog.id}>
          {blog.title} — <em>{blog.views} views</em>
        </li>
      ))}
    </ul>
  </div>
);

export default BlogDetails;
