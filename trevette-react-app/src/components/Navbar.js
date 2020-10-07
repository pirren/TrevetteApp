import React, { Component } from 'react'

export default class Navbar extends Component {
    render() {
        return (
            <div className="navbar-container">
                <nav className="navbar navbar-expand-lg justift-content-between navbar-light">
                    <a className="navbar-brand" href="#">
                        <div className="trevette-logo"></div>
                    </a>
                    <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarMenu" aria-controls="navbarMenu" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>

                    <div className="collapse navbar-collapse" id="navbarMenu">
                        <ul className="navbar-nav mr-auto">
                            <li className="nav-item">
                                <a className="nav-link" href="#">Garaget</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#">Om Trevette</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#">Kontakta</a>
                            </li>
                        </ul>
                    </div>
                </nav>
            </div>
        )
    }
}
