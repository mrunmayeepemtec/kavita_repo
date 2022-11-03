import React from 'react'
import './CSS/navbar.css'
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom'
import AddHotel from './AddHotel'
import RestaurantList from './RestaurantList'
import RestaurantUpdate from './RestaurantUpdate'
import ListOfBooking from './ListOfBooking'
import ListOfCanceled from './ListOfCanceled'
import UserList from './UserList'
import MarkBooking from './MarkBooking'

const Navbar = () => {
    return (
        <div>
            <Router>
                <nav className="navbar navbar-expand-lg">
                    <Link className="navbar-brand" to="#">Admin</Link>
                    <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarNav">
                        <ul className="navbar-nav">
                            <li className="nav-item active">
                                <Link className="nav-link" to="/">Add Hotel</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/RestaurantList">List of Hotel</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/RestaurantUpdate">Update</Link>
                            </li>
                            <li className="nav-item">
                            <Link className="nav-link" to="/ListOfBooking">List of Bookings</Link>
                        </li>
                        <li className="nav-item">
                            <Link className="nav-link" to="/ListOfCanceled">List of Canceled Bookings</Link>
                        </li>
                        <li className="nav-item">
                            <Link className="nav-link" to="/UserList">List of Users</Link>
                        </li>
                        <li className="nav-item">
                            <Link className="nav-link" to="/MarkBooking">Mark Booking</Link>
                        </li>
                        </ul>
                    </div>
                </nav>

                <Routes>
                    <Route path="/RestaurantList" element={<RestaurantList />} />

                    <Route path="/RestaurantUpdate" element={ <RestaurantUpdate />} />

                    <Route path="/ListOfBooking" element={<ListOfBooking />} />

                    <Route path="/ListOfCanceled" element={<ListOfCanceled />} />

                    <Route path="/UserList" element={<UserList /> } />

                    <Route path="/MarkBooking" element={<MarkBooking />} />

                    <Route path="/" element={<AddHotel />} />

                </Routes>

            </Router>
        </div>
    )
}

export default Navbar
