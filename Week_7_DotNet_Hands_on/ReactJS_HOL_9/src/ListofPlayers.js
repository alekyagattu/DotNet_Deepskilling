import React from 'react';

const ListofPlayers = () => {
  const players = [
    { name: "Virat", score: 85 },
    { name: "Rohit", score: 70 },
    { name: "Rahul", score: 65 },
    { name: "Jadeja", score: 78 },
    { name: "Ashwin", score: 55 },
    { name: "Pant", score: 90 },
    { name: "Hardik", score: 45 },
    { name: "Bumrah", score: 73 },
    { name: "Shami", score: 68 },
    { name: "Surya", score: 88 },
    { name: "Gill", score: 77 },
  ];

  // Filter players with score < 70 using arrow function
  const lowScorers = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>All Players</h2>
      <ul>
        {players.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>

      <h3>Players with score below 70</h3>
      <ul>
        {lowScorers.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>
    </div>
  );
};

export default ListofPlayers;
