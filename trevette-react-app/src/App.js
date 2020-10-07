import React, { Component } from 'react';
import Navbar from './components/Navbar';
import Cars from './components/Car/Cars';
import Garage from './components/Garage';

import "jquery/dist/jquery.min.js";

import "bootstrap/js/dist/collapse.js";
import "bootstrap/dist/css/bootstrap.min.css";

import "./css/App.css";

import axios from 'axios';

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      cars: []
    }
  }

  componentDidMount() {
    axios.get('https://localhost:44342/api/v1.0/Car/Forsale')
    .then(res => { this.setState({cars: res.data}) } )
    .catch(err => {console.log(err)}); 
  }

  render() {
    return (
      <div>
        <Navbar />

        <div className="container main-container">

          <div className="wrap-main">
            <div className="object-wrap">
              <Cars cars={this.state.cars} />
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
