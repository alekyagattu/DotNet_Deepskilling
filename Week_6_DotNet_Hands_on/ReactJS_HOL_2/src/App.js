import React from 'react';
import CalculateScore from './Components/CalculateScore';

function App() {
  return (
    <div className="App">
      <CalculateScore name="Alekya" school="ABC Public School" total={450} goal={5} />
    </div>
  );
}

export default App;

