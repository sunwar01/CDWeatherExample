/* Use MySQL dialect */
CREATE TABLE Forecasts (
    id INT AUTO_INCREMENT PRIMARY KEY,
    `date` DATE NOT NULL UNIQUE,
    temperatureC INT NOT NULL,
    summary VARCHAR(100) NOT NULL
);