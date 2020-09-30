import React from 'react';
import Navbar from './components/Navbar';
import CurrentObject from './components/CurrentObject';
import Garage from './components/Garage';

import "jquery/dist/jquery.min.js";

import "bootstrap/js/dist/collapse.js";
import "bootstrap/dist/css/bootstrap.min.css";

import "./css/App.css";

import uuid from "uuid";

function App() {
  return (
    <div>
      <div className="navbar-container">
        <Navbar />
      </div>

      <div className="container main-container">
        <div class="wrap-main">
          <div class="object-wrap">
            <CurrentObject />
          </div>
        </div>
        <div class="wrap-garage">
          <h2>Tidigare i Garaget</h2>
          <Garage />
        </div>
      </div>
    </div>
  );
}

export default App;
