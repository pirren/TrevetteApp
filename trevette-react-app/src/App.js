import React, { Component } from 'react';
import Navbar from './components/Navbar';
import Car from './components/Car';
import Garage from './components/Garage';

import "jquery/dist/jquery.min.js";

import "bootstrap/js/dist/collapse.js";
import "bootstrap/dist/css/bootstrap.min.css";

import "./css/App.css";

import axios from 'axios';

class App extends Component {
  state = {
    car: 
      {
        carid: 1,
        model: "Porsche 911 Carrera",
        year: 1980,
        mileage: 15000,
        title: "Tidlös maskin",
        description: "Den nya porschen är riktigt fet. Har en 3 L motor och gör 100 km/h på 3.7 s med sport-chrono paket. Denna vagn är för dom riktigt rika.",
        inStock: true,
        badges: [
          {
            title: "Läderinredning"
          },
          {
            title: "V8 Motor"
          }, 
          {
            title: "Specialobjekt"
          }
        ]
      }
  }

  componentDidMount() {
    axios.get('https://jsonplaceholder.typicode.com/todos?_limit=1')
    .then(response => this.setState({todos: response.data}));
  }

  render() {
    return (
      <div>
        <div className="navbar-container">
          <Navbar />
        </div>

        <div className="container main-container">
          <div className="wrap-main">
            <div className="object-wrap">
              <Car car={this.state.car} />
            </div>
          </div>
          <div className="wrap-garage">
            <h2>Tidigare i Garaget</h2>
            <Garage />
          </div>
        </div>
      </div>
    );
  }
}

export default App;
