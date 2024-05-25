import React from 'react';
import './css/Home.css'; // Import Home CSS
import reactImage from './image1.png';

const Home = () => {
  return (
    <div className="home-container">
      <img src={reactImage} alt="Sample" className="home-image" style={{ width: 600, height: 330 }} />
    </div>
  );
}

export default Home;
