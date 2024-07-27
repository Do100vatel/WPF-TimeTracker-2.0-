const mongoose = require('mongoose');

const timerSchema = new mongoose.Schema({
    name: { type: String, required: true },
    category: { type: String, required: true },
    startTime: { type: Date, required: true },
    endTime: { type: Date }
});

module.exports = mongoose.model('Timer', timerSchema);