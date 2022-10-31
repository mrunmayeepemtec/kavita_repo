import React from 'react'
import ReactStars from "react-rating-stars-component";
import './CSS/rating.css'

const Rating = () => {

    const ratingChanged = (newRating) =>{
        console.log(newRating);
    };

  return (
    <div className="contact-box">
        <h1>Feedback</h1>
      <ReactStars
        count={5}
        onChange={ratingChanged}
        size={45}
        isHalf={true}
        emptyIcon={<i className="far fa-star"></i>}
        halfIcon={<i className="fa fa-star-half-alt"></i>}
        fullIcon={<i className="fa fa-star"></i>}
        activeColor="#ffd700">

      </ReactStars>

      <textarea type="text" name="textarea" placeholder="Enter feedback"></textarea>
    </div>
  )
}

export default Rating
