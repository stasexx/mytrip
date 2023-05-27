import React from 'react';
import Star from './star';


const StarRating = ({starsSelected, totalStars=5, onRate=f=>f}) =>
<div className="star-rating">    
            {[...Array(totalStars)].map((n, i) =>
            <Star key={i}
             selected={i<starsSelected}
             onClick={() => onRate(i+1)}/>
             )}
</div>


export default StarRating