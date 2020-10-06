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
  constructor(props) {
    super(props);
    this.state = {
      car: [],
      salesObject: ""
    }
  }


  componentDidMount() {
    axios.get('https://localhost:44342/api/v1.0/Car/Forsale')
    // .then(response => this.setState({car: response.data[0]}))
    .then(response =>  {

      console.log('full response: ', response.data)
      console.log('sales object', response.data.salesobject.title)
      })
    .catch(err => {console.log(err)}); 
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
