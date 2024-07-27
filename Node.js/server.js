const express = require('express');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');
const cors = require('cors');
const Timer = require('./time-tracker-server/models/timer'); // Обновленный путь
const Category = require('./time-tracker-server/models/category'); // Обновленный путь

const app = express();
const port = 3000;

// Middleware
app.use(bodyParser.json());
app.use(cors());

// MongoDB connection
mongoose.connect('mongodb://localhost:27017/time-tracker', {
    useNewUrlParser: true,
    useUnifiedTopology: true
}).then(() => console.log('MongoDB connected'))
    .catch(err => console.log('MongoDB connection error:', err));

// Маршруты для категорий
app.get('/api/categories', async (req, res) => {
    try {
        const categories = await Category.find();
        res.json(categories);
    } catch (error) {
        res.status(500).send(error);
    }
});

app.post('/api/categories', async (req, res) => {
    try {
        const category = new Category(req.body);
        await category.save();
        res.json(category);
    } catch (error) {
        res.status(500).send(error);
    }
});

app.delete('/api/categories/:id', async (req, res) => {
    try {
        await Category.findByIdAndDelete(req.params.id);
        res.json({ message: 'Category deleted' });
    } catch (error) {
        res.status(500).send(error);
    }
});

// Маршруты для таймеров
app.get('/api/timers', async (req, res) => {
    try {
        const timers = await Timer.find();
        res.json(timers);
    } catch (error) {
        res.status(500).send(error);
    }
});

app.post('/api/categories', async (req, res) => {
    try {
        const category = new Category(req.body);
        await category.save();
        res.json(category);
    } catch (error) {
        console.error('Error creating category:', error);
        res.status(500).send({ message: 'Internal Server Error', error });
    }
});

app.delete('/api/timers/:id', async (req, res) => {
    try {
        await Timer.findByIdAndDelete(req.params.id);
        res.json({ message: 'Timer deleted' });
    } catch (error) {
        res.status(500).send(error);
    }
});

app.listen(port, () => {
    console.log(`Server running on port ${port}`);
});
