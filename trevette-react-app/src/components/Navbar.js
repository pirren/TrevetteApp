import React, { Component } from 'react'
import { BrowserRouter as Router, Route, Link } from 'react-router-dom';


export default class Navbar extends Component {
    render() {
        return (
            <div className="navbar-container">
                <nav className="navbar navbar-expand-lg justift-content-between navbar-light">
                    <Link className="navbar-brand" to="/">
                        <div className="trevette-logo"></div>
                    </Link>
                    <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarMenu" aria-controls="navbarMenu" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>

                    <div className="collapse navbar-collapse" id="navbarMenu">
                        <ul className="navbar-nav mr-auto">
                            <li className="nav-item">
                                <Link className="nav-link" to="/">Garaget</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/About">Om Trevette</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/Contact">Kontakta</Link>
                            </li>
                        </ul>
                    </div>
                </nav>
            </div>
        )
    }
}
