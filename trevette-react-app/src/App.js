import React from 'react';
import Navbar from './components/Navbar';

import "jquery/dist/jquery.min.js";

import "bootstrap/js/dist/collapse.js";
import "bootstrap/dist/css/bootstrap.min.css";
import "font-awesome/css/font-awesome.min.css";

import "./css/App.css";

import uuid from "uuid";

function App() {
  return (
    <div className="navbar-container">
      <Navbar />
    </div>
  );
}

export default App;
