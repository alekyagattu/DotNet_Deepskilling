import React from 'react';

const IndianPlayers = () => {
  // Destructure players into odd/even team
  const team = ["Virat", "Rohit", "Rahul", "Jadeja", "Pant", "Ashwin"];
  const oddTeam = team.filter((_, i) => i % 2 !== 0);
  const evenTeam = team.filter((_, i) => i % 2 === 0);

  // Merge T20 and Ranji players
  const T20players = ["Gill", "Surya", "Hardik"];
  const RanjiPlayers = ["Pujara", "Saha", "Karun Nair"];
  const allPlayers = [...T20players, ...RanjiPlayers]; // spread operator

  return (
    <div>
      <h2>Odd Team Players</h2>
      <ul>
        {oddTeam.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h2>Even Team Players</h2>
      <ul>
        {evenTeam.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h2>Merged Players (T20 + Ranji)</h2>
      <ul>
        {allPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>
    </div>
  );
};

export default IndianPlayers;
