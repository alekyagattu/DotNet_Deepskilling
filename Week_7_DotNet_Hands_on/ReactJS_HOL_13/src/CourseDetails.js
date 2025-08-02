import React from 'react';

const CourseDetails = () => {
  const courses = ["React Fundamentals", "JSX Deep Dive", "Hooks & Context"];

  return (
    <div>
      <h2>Course Details</h2>
      <ul>
        {courses.map((course, index) => (
          <li key={index}>{course}</li>  // key is required here
        ))}
      </ul>
    </div>
  );
};

export default CourseDetails;
