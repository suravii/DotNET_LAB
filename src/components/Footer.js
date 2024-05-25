import React from 'react';
import './css/Footer.css'; // Import Footer CSS

const Footer = () => {
  return (
    <footer className="footer">
      
      <p>&copy; Suravi Shrestha, {new Date().getFullYear()}</p>
    </footer>
  );
}

export default Footer;
