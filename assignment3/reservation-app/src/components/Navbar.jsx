import React from 'react'
import './CSS/navbar.css'
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom'
import ListOfHotel from './ListOfHotel'
import SelectedHotelDetails from './SelectedHotelDetails'
import BookTable from './BookTable'
import BookHistory from './BookHistory'
import CancelReservation from './CancelReservation'

const Navbar = () => {
    return (
        <div>
            <Router>
                <nav className="navbar navbar-expand-lg">
                    <Link className="navbar-brand" to="#">Client</Link>
                    <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarNav">
                        <ul className="navbar-nav">
                            <li className="nav-item active">
                                <Link className="nav-link" to="/">List of Hotel</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/selectedhoteldetails">Selected Hotel Details</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/booktable">Book Table</Link>
                            </li>
                            <li className="nav-item">
                            <Link className="nav-link" to="/bookinghistory">Booking History</Link>
                        </li>
                        <li className="nav-item">
                            <Link className="nav-link" to="/cancelreservation">Cancel Reservation</Link>
                        </li>
                       
                        </ul>
                    </div>
                </nav>

                <Routes>
                    <Route path="/selectedhoteldetails" element={<SelectedHotelDetails />} />

                    <Route path="/booktable" element={ <BookTable />} />

                    <Route path="/bookinghistory" element={<BookHistory />} />

                    <Route path="/cancelreservation" element={<CancelReservation />} />

                    <Route path="/" element={<ListOfHotel /> } />

                </Routes>

            </Router>
        </div>
    )
}

export default Navbar
