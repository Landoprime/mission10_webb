import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './BowlerList';


function GoButton() {
  return (
    <div>
      <h1>Yo what up</h1>
    </div>
  );
}

function App() {
  return (
    <div className="App">
      <Header title="Bowlers Info" />
      <BowlerList />
    </div>
  );
}

export default App;
