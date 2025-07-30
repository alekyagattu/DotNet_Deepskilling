import React from 'react';
import { useParams } from 'react-router-dom';
import TrainersMock from './TrainersMock';

function TrainerDetails() {
  const { id } = useParams();
  const trainer = TrainersMock.find(t => t.trainerId === parseInt(id));

  if (!trainer) return <p>Trainer not found</p>;

  return (
    <div>
      <h2>{trainer.name} - Details</h2>
      <p><strong>ID:</strong> {trainer.trainerId}</p>
      <p><strong>Email:</strong> {trainer.email}</p>
      <p><strong>Phone:</strong> {trainer.phone}</p>
      <p><strong>Technology:</strong> {trainer.technology}</p>
      <p><strong>Skills:</strong> {trainer.skills.join(', ')}</p>
    </div>
  );
}

export default TrainerDetails;
