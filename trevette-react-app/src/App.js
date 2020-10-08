import React, { Component } from 'react';

import { BrowserRouter as Router, Route } from 'react-router-dom';

import Navbar from './components/Navbar';
import Cars from './components/Car/Cars';
import Garage from './components/Garage';

import About from './components/Pages/About';
import Dashboard from './components/Pages/Dashboard/Dashboard';
import DashboardMenu from './components/Pages/Dashboard/DashboardSide';

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
      <Router>
        <Navbar />

        <div className="container main-container">

          {/* Main content */}
          <div className="wrap-main">
            <div className="component-wrap">
            <Route exact path="/" render={props => (
              <React.Fragment>
                <Cars cars={this.state.cars} />
              </React.Fragment>
            )} />
            <Route path="/About" component={About} />
            <Route path="/Dashboard" component={Dashboard} />
            </div>
          </div>
          {/* Left-hand side */}
          <div className="wrap-side">
              <Route exact path="/" component={Garage} />
              <Route path="/Dashboard" component={DashboardMenu} />
          </div>

        </div>
      </Router>
    );
  }
}

export default App;
